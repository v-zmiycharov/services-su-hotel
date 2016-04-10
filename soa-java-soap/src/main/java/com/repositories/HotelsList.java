package com.repositories;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

import com.sources.hotels.Category;
import com.sources.hotels.Contacts;
import com.sources.hotels.Facilities;
import com.sources.hotels.Hotel;
import com.sources.hotels.PriceList;

public class HotelsList {
	
	private static final List<Hotel> hotels = new ArrayList<Hotel>();
	
	public static List<Hotel> getList() {
		addHotel1();
		addHotel2();
		addHotel3();
		addHotel4();
		addHotel5();
		addHotel6();
		addHotel7();
		
		return hotels;
	}
	
	
	private static void addHotel1() {
		Hotel h1 = new Hotel();
		h1.setId(1);
		h1.setCityId(2);
		h1.setCityName("Sofia");
		h1.setCategory(Category.BUSINESS);
		h1.setName("Sofia Hotel Balkan");
		h1.setStars(5);
		h1.setDescription("Enjoying a privileged location in the heart of Sofia, next to Serdika Underground Station, the exclusive Sofia Hotel Balkan, A Luxury Collection Hotel offers free access to the on-site casino. It includes the Pliska Bar and the Stardust Restaurant. The Sofia Balkan Hotel provides various dining options, a health club, a 24-hour business centre, and various shops. You also enjoy free WiFi access in the lobby. Sofia Airport and the Mladost Business Park are 10 km from this Luxury Collection Hotel. The Mall and the Armeec Arena are 6 km away.");
		h1.setRoomCount(184);
		Contacts c1 = new Contacts();
		c1.setAddress("5,Sveta Nedelya Square");
		c1.setPhoneNumber("02 9816 541");
		h1.setContacts(c1);
		PriceList p1 = new PriceList();
		p1.setSingleRoom(89);
		p1.setDoubleRoom(112);
		p1.setTripleRoom(120);
		h1.setPriceList(p1);
		Facilities f1 = new Facilities();
		f1.getFacility().addAll(Arrays.asList(
				new String[] {""} ));
		h1.setFacilities(f1);
		
		hotels.add(h1);
	}
	
	private static void addHotel2() {
		Hotel h2 = new Hotel();
		h2.setId(2);
		h2.setCityId(2);
		h2.setCityName("Sofia");
		h2.setCategory(Category.SPA);
		h2.setName("Holiday Inn Sofia");
		h2.setStars(5);
		h2.setDescription("Offering a spa and fitness area with an indoor pool, this 5-star hotel in the foothills of the Vitosha Mountains is just a 10-minute drive from the city centre and Sofia Airport. Free and secure underground parking is available. The spacious, air-conditioned rooms at Holiday Inn Sofia all feature a minibar and an LCD flat-screen TV with a wide range of satellite channels. Bathrooms feature separate baths and showers. Some rooms offer views of the Vitosha Mountains. The Sofia Holiday Inn’s Esprit Fitness and Spa features indoor and outdoor hot tubs, a sauna, steam bath, sun bed, and separate children’s pool. Various beauty treatments and massages are offered. The modern, air-conditioned gym provides the latest TechnoGym equipment. Featuring a terrace overlooking the mountains and the lake, the modern and stylish Brasserie Restaurant and Terrace serves Bulgarian and international cuisine. Lunch and dinner buffets are offered regularly. A wide range of drinks is available at the Chi Bar, which also offers live piano music. Room service, security, and reception services are available around the clock. Guests also benefit from a business centre and an on-site hairdresser. Located in the Sofia Business Park, the Holiday Inn is just a 5 to 10-minute drive or shuttle bus ride from various shopping centres and event locations, including the Inter Expo Center. The hotel’s numerous international awards include the Intercontinental Hotels Group Torchbearer Award in 2009/10/11/12/13 and the Tripadvisor Travellers’ Choice Award 2013.");
		h2.setRoomCount(130);
		Contacts c2 = new Contacts();
		c2.setAddress("111, Alexandar Malinov Blvd.");
		c2.setPhoneNumber("02 8070 707");
		h2.setContacts(c2);
		PriceList p2 = new PriceList();
		p2.setSingleRoom(153);
		p2.setDoubleRoom(170);
		p2.setTripleRoom(200);
		h2.setPriceList(p2);
		Facilities f2 = new Facilities();
		f2.getFacility().addAll(Arrays.asList(
				new String[] {""} ));
		h2.setFacilities(f2);
		
		hotels.add(h2);
	}
	
	private static void addHotel3() {
		Hotel h3 = new Hotel();
		h3.setId(3);
		h3.setCityId(1);
		h3.setCityName("Varna");
		h3.setCategory(Category.BUSINESS);
		h3.setName("Boutique Splendid Hotel");
		h3.setStars(4);
		h3.setDescription("Hotel Splendid is located in the centre of Varna next to The Cathedral of The Assumption. It offers air conditioned rooms with free WiFi access and SAT TV. The hotel is housed in a 100-year-old renovated building and close to the pedestrian shopping street, the Opera House and Varna's theatre. Hotel Splendid is next to the stop of the airport bus 409. You can easily get to the promenade and the beach of Varna or to Golden Sands resort. An airport shuttle is available on request.");
		h3.setRoomCount(26);
		Contacts c3 = new Contacts();
		c3.setAddress("30, Bratya Shkorpil St.");
		c3.setPhoneNumber("052 681 414");
		h3.setContacts(c3);
		PriceList p3 = new PriceList();
		p3.setSingleRoom(42);
		p3.setDoubleRoom(53);
		p3.setTripleRoom(60);
		h3.setPriceList(p3);
		Facilities f3 = new Facilities();
		f3.getFacility().addAll(Arrays.asList(
				new String[] {""} ));
		h3.setFacilities(f3);
		
		hotels.add(h3);
	}
	
	private static void addHotel4() {
		Hotel h4 = new Hotel();
		h4.setId(4);
		h4.setCityId(3);
		h4.setCityName("Plovdiv");
		h4.setCategory(Category.BUSINESS);
		h4.setName("Hotel Imperial");
		h4.setStars(4);
		h4.setDescription("Hotel Imperial-Plovdiv is centrally located in a private garden close to the old town of Plovdiv, the Roman Theatre and the Plovdiv International Fair. The elegant and comfortable rooms are carefully designed, and some of them overlook the private garden. They feature LED TV, minibar, individual air-conditioning and free high speed wireless internet. The restaurant serves delicious meals and desserts. It has 2 halls and is suitable for organising diverse events. There is also a congress centre, as well as a cosy lobby bar. Massage services provide for relaxation after a day of doing business or sightseeing. On advanced request, Imperial-Plovdiv Hotel provides a free shuttle service to Plovdiv Airport and to the International Fair.");
		h4.setRoomCount(190);
		Contacts c4 = new Contacts();
		c4.setAddress("1A Arch. Kamen Petkov");
		c4.setPhoneNumber("032 600 730");
		h4.setContacts(c4);
		PriceList p4 = new PriceList();
		p4.setSingleRoom(61);
		p4.setDoubleRoom(81);
		p4.setTripleRoom(81);
		h4.setPriceList(p4);
		Facilities f4 = new Facilities();
		f4.getFacility().addAll(Arrays.asList(
				new String[] {""} ));
		h4.setFacilities(f4);
		
		hotels.add(h4);
	}
	
	private static void addHotel5() {
		Hotel h5 = new Hotel();
		h5.setId(5);
		h5.setCityId(5);
		h5.setCityName("Veliko Tarnovo");
		h5.setCategory(Category.FAMILY);
		h5.setName("Hotel Concorde");
		h5.setStars(3);
		h5.setDescription("Hotel Concorde is located in the central part of Veliko Tarnovo on a quiet and peaceful street. Only a five minute walk from the town centre and all the action. The hotel has four floors and luxury elevator. From the last floor of the hotel, there is beautiful view of the hill Sveta Gora and architectural reserve of Arbanasi. The building is listed as a cultural monument of the old town and the interior of the hotel is all in style of French fine taste and Italian classic. The hotel has comfortably lobby bar, conference hall, sauna and relaxing colour recess. Additionally, for ours guests the hotel has parking area, taxi, rent a car, original bouquet and custom flowers.");
		h5.setRoomCount(17);
		Contacts c5 = new Contacts();
		c5.setAddress("St.14 Tzanko Tzerkovski");
		c5.setPhoneNumber("062 602 221");
		h5.setContacts(c5);
		PriceList p5 = new PriceList();
		p5.setSingleRoom(55);
		p5.setDoubleRoom(69);
		p5.setTripleRoom(76);
		h5.setPriceList(p5);
		Facilities f5 = new Facilities();
		f5.getFacility().addAll(Arrays.asList(
				new String[] {""} ));
		h5.setFacilities(f5);
		
		hotels.add(h5);
	}
	
	private static void addHotel6() {
		Hotel h6 = new Hotel();
		h6.setId(6);
		h6.setCityId(4);
		h6.setCityName("Ruse");
		h6.setCategory(Category.BUSINESS);
		h6.setName("Riga Hotel");
		h6.setStars(3);
		h6.setDescription("Directly set on the shores of the Danube River, award-winning Riga Hotel is only 400 metres from the Ruse Main Square. It offers free Wi-Fi, a breakfast, free access to its spa facilities and free underground parking. All rooms and suites provide air conditioning, a comfortable seating area and a flat-screen cable TV. All rooms have a view of the river. The renowned Panorama Restaurant features a panoramic view of the city and the harbour, and serves pan-European cuisine. Guests can also enjoy their meals in the restaurant's garden.The extravagant-style lobby is open 24-hours a day. The Mehana restaurant is a traditional Bulgarian tavern. A Viennese Confectionery, garden restaurant and a summer lounge bar are also part of the Riga Hotel, the biggest hotel complex in Ruse. Guests have free access to the hotel's spa area which includes a hot tub, a steam bath and a sauna. A fitness centre is also on site. 8 multifunctional conference halls with capacity from 10 to 400 seats is available on site.");
		h6.setRoomCount(157);
		Contacts c6 = new Contacts();
		c6.setAddress("22 Pridunavski Bul.");
		c6.setPhoneNumber("082 822 042");
		h6.setContacts(c6);
		PriceList p6 = new PriceList();
		p6.setSingleRoom(53);
		p6.setDoubleRoom(66);
		p6.setTripleRoom(80);
		h6.setPriceList(p6);
		Facilities f6 = new Facilities();
		f6.getFacility().addAll(Arrays.asList(
				new String[] {""} ));
		h6.setFacilities(f6);
		
		hotels.add(h6);
	}
	
	private static void addHotel7() {
		Hotel h7 = new Hotel();
		h7.setId(7);
		h7.setCityName("Burgas");
		h7.setCityId(6);
		h7.setCategory(Category.FAMILY);
		h7.setName("Hotel Lazuren Briag");
		h7.setStars(2);
		h7.setDescription("Situated on the Black Sea coast of Burgas, Hotel Lazuren Briag is just 100 metres away from the beach. It offers free Wi-Fi and air conditioning. Guests can also enjoy drinks in the summer garden or in the hotel bar. A restaurant serving international cuisine is situated on site and daily newspapers can be found in the lobby. The hotel also provides ironing and laundry services and the reception is open 24 hours a day. The main shopping street is a short walk away, while a more ambitious shopper can visit the Carrefour Shopping Centre which is located 6 km away from the hotel. The sandy beach in front of the hotel offers sun loungers and parasols. Lazuren Briag also offers car-rental options, while a free shuttle service to the Burgas Airport can be arranged upon request. The local bus stop is located 200 meters from Hotel Lazuren Briag.");
		h7.setRoomCount(20);
		Contacts c7 = new Contacts();
		c7.setAddress("Sarafovo, 1 Ribarska str.");
		c7.setPhoneNumber("056 873 218");
		h7.setContacts(c7);
		PriceList p7 = new PriceList();
		p7.setSingleRoom(27);
		p7.setDoubleRoom(31);
		p7.setTripleRoom(34);
		h7.setPriceList(p7);
		Facilities f7 = new Facilities();
		f7.getFacility().addAll(Arrays.asList(
				new String[] {""} ));
		h7.setFacilities(f7);
		
		hotels.add(h7);
	}
}
