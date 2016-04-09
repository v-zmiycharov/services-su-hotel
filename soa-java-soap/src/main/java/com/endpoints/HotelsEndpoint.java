package com.endpoints;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.ws.server.endpoint.annotation.Endpoint;
import org.springframework.ws.server.endpoint.annotation.PayloadRoot;
import org.springframework.ws.server.endpoint.annotation.RequestPayload;
import org.springframework.ws.server.endpoint.annotation.ResponsePayload;

import com.repositories.HotelsRepository;
import com.sources.hotels.GetHotelDetailsRequest;
import com.sources.hotels.GetHotelDetailsResponse;
import com.sources.hotels.GetHotelRequest;
import com.sources.hotels.GetHotelResponse;
import com.sources.hotels.GetHotelsRequest;
import com.sources.hotels.GetHotelsResponse;

@Endpoint
public class HotelsEndpoint {
	private static final String NAMESPACE_URI = "http://hotels.sources.com";

	private HotelsRepository hotelsRepository;

	@Autowired
	public HotelsEndpoint(HotelsRepository hotelsRepository) {
		this.hotelsRepository = hotelsRepository;
	}
	
	@PayloadRoot(namespace = NAMESPACE_URI, localPart = "getHotelRequest")
	@ResponsePayload
	public GetHotelResponse getHotel(@RequestPayload GetHotelRequest request) {
		GetHotelResponse response = new GetHotelResponse();
		response.setHotel(hotelsRepository.findHotel(request.getId()));

		return response;
	}

	@PayloadRoot(namespace = NAMESPACE_URI, localPart = "getHotelsRequest")
	@ResponsePayload
	public GetHotelsResponse getHotels(@RequestPayload GetHotelsRequest request) {
		GetHotelsResponse response = new GetHotelsResponse();
		response.setHotels(hotelsRepository.findHotels(request.getTerm(), request.getCityId()));

		return response;
	}
	
	@PayloadRoot(namespace = NAMESPACE_URI, localPart = "getHotelDetailsRequest")
	@ResponsePayload
	public GetHotelDetailsResponse getHotelDetails(@RequestPayload GetHotelDetailsRequest request) {
		GetHotelDetailsResponse response = new GetHotelDetailsResponse();
		response.setHotel(hotelsRepository.getDetails(request.getId()));

		return response;
	}
}
