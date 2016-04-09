package com.config;
import org.springframework.boot.context.embedded.ServletRegistrationBean;
import org.springframework.context.ApplicationContext;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.core.io.ClassPathResource;
import org.springframework.ws.config.annotation.EnableWs;
import org.springframework.ws.config.annotation.WsConfigurerAdapter;
import org.springframework.ws.transport.http.MessageDispatcherServlet;
import org.springframework.ws.wsdl.wsdl11.DefaultWsdl11Definition;
import org.springframework.xml.xsd.SimpleXsdSchema;
import org.springframework.xml.xsd.XsdSchema;

@EnableWs
@Configuration
public class WebServiceConfig extends WsConfigurerAdapter {
	@Bean
	public ServletRegistrationBean messageDispatcherServlet(ApplicationContext applicationContext) {
		MessageDispatcherServlet servlet = new MessageDispatcherServlet();
		servlet.setApplicationContext(applicationContext);
		servlet.setTransformWsdlLocations(true);
		return new ServletRegistrationBean(servlet, "/ws/*");
	}

	@Bean(name = "cities")
	public DefaultWsdl11Definition defaultWsdl11Definition(XsdSchema citiesSchema) {
		DefaultWsdl11Definition wsdl11Definition = new DefaultWsdl11Definition();
		wsdl11Definition.setPortTypeName("CitiesPort");
		wsdl11Definition.setLocationUri("/ws/cities");
		wsdl11Definition.setTargetNamespace("http://cities.sources.com");
		wsdl11Definition.setSchema(citiesSchema);
		return wsdl11Definition;
	}

	@Bean
	public XsdSchema citiesSchema() {
		return new SimpleXsdSchema(new ClassPathResource("cities.xsd"));
	}
	
	@Bean(name = "hotels")
	public DefaultWsdl11Definition hotelsWsdl1Definition(XsdSchema hotelsSchema) {
		DefaultWsdl11Definition wsdl11Definition = new DefaultWsdl11Definition();
		wsdl11Definition.setPortTypeName("HotelsPort");
		wsdl11Definition.setLocationUri("/ws/hotels");
		wsdl11Definition.setTargetNamespace("http://hotels.sources.com");
		wsdl11Definition.setSchema(hotelsSchema);
		return wsdl11Definition;
	}

	@Bean
	public XsdSchema hotelsSchema() {
		return new SimpleXsdSchema(new ClassPathResource("hotels.xsd"));
	}
}