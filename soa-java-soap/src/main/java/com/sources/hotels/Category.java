//
// This file was generated by the JavaTM Architecture for XML Binding(JAXB) Reference Implementation, v2.2.4 
// See <a href="http://java.sun.com/xml/jaxb">http://java.sun.com/xml/jaxb</a> 
// Any modifications to this file will be lost upon recompilation of the source schema. 
// Generated on: 2016.04.18 at 02:46:39 AM PDT 
//


package com.sources.hotels;

import javax.xml.bind.annotation.XmlEnum;
import javax.xml.bind.annotation.XmlEnumValue;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for category.
 * 
 * <p>The following schema fragment specifies the expected content contained within this class.
 * <p>
 * <pre>
 * &lt;simpleType name="category">
 *   &lt;restriction base="{http://www.w3.org/2001/XMLSchema}string">
 *     &lt;enumeration value="business"/>
 *     &lt;enumeration value="family"/>
 *     &lt;enumeration value="spa"/>
 *   &lt;/restriction>
 * &lt;/simpleType>
 * </pre>
 * 
 */
@XmlType(name = "category")
@XmlEnum
public enum Category {

    @XmlEnumValue("business")
    BUSINESS("business"),
    @XmlEnumValue("family")
    FAMILY("family"),
    @XmlEnumValue("spa")
    SPA("spa");
    private final String value;

    Category(String v) {
        value = v;
    }

    public String value() {
        return value;
    }

    public static Category fromValue(String v) {
        for (Category c: Category.values()) {
            if (c.value.equals(v)) {
                return c;
            }
        }
        throw new IllegalArgumentException(v);
    }

}
