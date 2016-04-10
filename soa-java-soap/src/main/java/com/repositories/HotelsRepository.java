package com.repositories;

import java.util.ArrayList;
import java.util.List;

import javax.annotation.PostConstruct;

import org.springframework.stereotype.Component;
import org.springframework.util.Assert;

import com.sources.hotels.Hotel;
import com.sources.hotels.Hotel1;
import com.sources.hotels.Hotels;

@Component
public class HotelsRepository {

	private static final List<Hotel> hotelsList = new ArrayList<Hotel>();
	
	
	@PostConstruct
	public void initData() {
		hotelsList.addAll(HotelsList.getList());
	}
	
	
	public Hotel1 findHotel(long id) {
		Assert.notNull(id);
		
		Hotel1 result = new Hotel1();
		
		for (Hotel hotel: hotelsList) {
			if (hotel.getId() == id) {
				result.setId(hotel.getId());
				result.setName(hotel.getName());
			}
		}
		
		return result;
	}
	
	
	public Hotels findHotels(String term, long cityId) {
		Hotels result = new Hotels();
		
		for (Hotel hotel : hotelsList) {
			if (
				( cityId != 0 && hotel.getCityId() == cityId
					&& (term.equals(null) || term.isEmpty()) )
				|| ( cityId != 0 && hotel.getCityId() == cityId
					&& !term.equals(null) && !term.isEmpty()
					&& hotel.getName().toLowerCase().contains(term.toLowerCase()) )
				|| ( cityId == 0 && !term.equals(null) && !term.isEmpty()
					&& hotel.getName().toLowerCase().contains(term.toLowerCase()) )
				|| ( cityId == 0 && (term.equals(null) || term.isEmpty()) )
				) {
				Hotel1 h = new Hotel1();
				h.setId(hotel.getId());
				h.setName(hotel.getName());
				result.getHotel().add(h);
			}
		}
		
		return result;
	}
	
	
	public Hotel getDetails(long id) {
		Assert.notNull(id);
		
		Hotel result = null;
		
		for (Hotel hotel : hotelsList) {
			if (hotel.getId() == id) {
				result = hotel;
			}
		}
		
		return result;
	}
}
