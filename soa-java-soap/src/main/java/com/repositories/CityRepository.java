package com.repositories;

import javax.annotation.PostConstruct;
import java.util.ArrayList;
import java.util.List;

import org.springframework.stereotype.Component;
import org.springframework.util.Assert;

import com.sources.cities.Cities;
import com.sources.cities.City;


@Component
public class CityRepository {
	private static final List<City> cities = new ArrayList<City>();

	@PostConstruct
	public void initData() {
		City varna = new City();
		varna.setId(1);
		varna.setName("Varna");
		cities.add(varna);

		City sofia = new City();
		sofia.setId(2);
		sofia.setName("Sofia");
		cities.add(sofia);

		City plovdiv = new City();
		plovdiv.setId(3);
		plovdiv.setName("Plovdiv");
		cities.add(plovdiv);
		
		City ruse = new City();
		ruse.setId(4);
		ruse.setName("Ruse");
		cities.add(ruse);
		
		City velikoTarnovo = new City();
		velikoTarnovo.setId(5);
		velikoTarnovo.setName("Veliko Tarnovo");
		cities.add(velikoTarnovo);
		
		City burgas = new City();
		burgas.setId(6);
		burgas.setName("Burgas");
		cities.add(burgas);
		
		City pazardzhik = new City();
		pazardzhik.setId(7);
		pazardzhik.setName("Pazardzhik");
		cities.add(pazardzhik);
	}

	public City findCity(long id) {
		Assert.notNull(id);

		City result = null;

		for (City city : cities) {
			if ( city.getId() == id ) {
				result = city;
			}
		}

		return result;
	}
	
	public Cities findCities(String term) {
		List<City> list = new ArrayList<City>();
		
		if (!term.equals(null) && !term.isEmpty()) {
			for (City city: cities) {
				if ( city.getName().toLowerCase().contains(term.toLowerCase()) ) {
					list.add(city);
				}
			}
		} else {
			list.addAll(cities);
		}
		
		Cities result = new Cities();
		result.getCity().addAll(list);
		
		return result;
	}
}
