package com.endpoints;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.ws.server.endpoint.annotation.Endpoint;
import org.springframework.ws.server.endpoint.annotation.PayloadRoot;
import org.springframework.ws.server.endpoint.annotation.RequestPayload;
import org.springframework.ws.server.endpoint.annotation.ResponsePayload;

import com.repositories.CityRepository;
import com.sources.cities.GetCitiesRequest;
import com.sources.cities.GetCitiesResponse;
import com.sources.cities.GetCityRequest;
import com.sources.cities.GetCityResponse;

@Endpoint
public class CityEndpoint {
	private static final String NAMESPACE_URI = "http://cities.sources.com";

	private CityRepository cityRepository;

	@Autowired
	public CityEndpoint(CityRepository cityRepository) {
		this.cityRepository = cityRepository;
	}

	@PayloadRoot(namespace = NAMESPACE_URI, localPart = "getCityRequest")
	@ResponsePayload
	public GetCityResponse getCity(@RequestPayload GetCityRequest request) {
		GetCityResponse response = new GetCityResponse();
		response.setCity(cityRepository.findCity(request.getId()));

		return response;
	}
	
	@PayloadRoot(namespace = NAMESPACE_URI, localPart = "getCitiesRequest")
	@ResponsePayload
	public GetCitiesResponse getCities(@RequestPayload GetCitiesRequest request) {
		GetCitiesResponse response = new GetCitiesResponse();
		response.setCities(cityRepository.findCities(request.getTerm()));

		return response;
	}
}
