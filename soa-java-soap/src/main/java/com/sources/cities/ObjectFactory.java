//
// This file was generated by the JavaTM Architecture for XML Binding(JAXB) Reference Implementation, v2.2.4 
// See <a href="http://java.sun.com/xml/jaxb">http://java.sun.com/xml/jaxb</a> 
// Any modifications to this file will be lost upon recompilation of the source schema. 
// Generated on: 2016.04.10 at 02:41:04 AM PDT 
//


package com.sources.cities;

import javax.xml.bind.annotation.XmlRegistry;


/**
 * This object contains factory methods for each 
 * Java content interface and Java element interface 
 * generated in the com.sources.cities package. 
 * <p>An ObjectFactory allows you to programatically 
 * construct new instances of the Java representation 
 * for XML content. The Java representation of XML 
 * content can consist of schema derived interfaces 
 * and classes representing the binding of schema 
 * type definitions, element declarations and model 
 * groups.  Factory methods for each of these are 
 * provided in this class.
 * 
 */
@XmlRegistry
public class ObjectFactory {


    /**
     * Create a new ObjectFactory that can be used to create new instances of schema derived classes for package: com.sources.cities
     * 
     */
    public ObjectFactory() {
    }

    /**
     * Create an instance of {@link GetCityRequest }
     * 
     */
    public GetCityRequest createGetCityRequest() {
        return new GetCityRequest();
    }

    /**
     * Create an instance of {@link GetCityResponse }
     * 
     */
    public GetCityResponse createGetCityResponse() {
        return new GetCityResponse();
    }

    /**
     * Create an instance of {@link City }
     * 
     */
    public City createCity() {
        return new City();
    }

    /**
     * Create an instance of {@link GetCitiesRequest }
     * 
     */
    public GetCitiesRequest createGetCitiesRequest() {
        return new GetCitiesRequest();
    }

    /**
     * Create an instance of {@link GetCitiesResponse }
     * 
     */
    public GetCitiesResponse createGetCitiesResponse() {
        return new GetCitiesResponse();
    }

    /**
     * Create an instance of {@link Cities }
     * 
     */
    public Cities createCities() {
        return new Cities();
    }

}
