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
		addHotel8();
		addHotel9();
		addHotel10();
		addHotel11();
		addHotel12();
		addHotel13();
		addHotel14();
		addHotel15();
		
		for (Hotel hotel : hotels) {
			hotel.getPriceList().setCurrency("EUR");
		}
		
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
				new String[] {"Fitness center", "Business center", "Restaurant", "Wi fi",
								"Sauna", "Wellness center", "Shops", "Bar"} ));
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
				new String[] {"Swimming pool", "Sauna", "Spa and wellness centre", "Wi fi",
						"Business center", "Restaurant", "Private parking", "Solarium", "Bar"} ));
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
				new String[] {"Free parking", "Meeting/Banquet facilities", "Gift shop",
								"Private parking", "Wi fi"} ));
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
				new String[] {"Free parking", "Sauna", "Spa and wellness center", "Wi fi",
							"Shops", "Bar", "Business center", "Restaurant", "Fitness center"} ));
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
				new String[] {"Free parking", "Garden", "Restaurant", "Sauna", "Wi fi"} ));
		h5.setFacilities(f5);
		
		hotels.add(h5);
	}
	
	private static void addHotel6() {
		Hotel h6 = new Hotel();
		h6.setId(6);
		h6.setCityId(4);
		h6.setCityName("Ruse");
		h6.setCategory(Category.BUSINESS);
		h6.setName("Grand Hotel Riga");
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
				new String[] {"Free parking", "Restaurant", "Meeting/Banquet facilities",
								"Sauna", "Fitness center", "Garden", "BBQ facilities",
								"Business center", "Hot tub", "Bar", "Wi fi"} ));
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
				new String[] {"Free parking", "Bar", "Garden", "Wi fi"} ));
		h7.setFacilities(f7);
		
		hotels.add(h7);
	}
	
	private static void addHotel8() {
		Hotel h8 = new Hotel();
		h8.setId(8);
		h8.setCityName("Sofia");
		h8.setCityId(2);
		h8.setCategory(Category.BUSINESS);
		h8.setName("St. George Hotel");
		h8.setStars(3);
		h8.setDescription("Located in a residential part of central Sofia, St. George offers modern accommodation 1 km from the focal National Assembly Square. Most rooms are self-contained and all features free Wi-Fi access.Rooms, studios and apartments at St. George Hotel open out onto a private balcony. All are equipped with cable TV channels and an electric kettle. Each room also includes a work desk and en suite bathrooms.Guests can enjoy Bulgarian dishes and some international classics at the restaurant of the hotel. Room service is also available. An airport shuttle can be arranged upon request. Staff at the 24-hour reception can help plan visits and excursions to popular nearby attractions, including the National Art Gallery.St. George Hotel is located a 10-minute walk away from Serdika Metro Station and a 15-minute walk away from The National Palace of Culture and Vitosha Boulevard pedestrian street. The major city landmarks are reachable within a 15-minute walk, including the Archaeological Museum, Ivan Vazov Theater and the Presidency Institution.");
		h8.setRoomCount(20);
		Contacts c8 = new Contacts();
		c8.setAddress("64, Knyaz Boris I Str., Sofia, Bulgaria");
		c8.setPhoneNumber("+359 2 465 01 30");
		h8.setContacts(c8);
		PriceList p8 = new PriceList();
		p8.setSingleRoom(43);
		p8.setDoubleRoom(49);
		p8.setTripleRoom(76);
		h8.setPriceList(p8);
		Facilities f8 = new Facilities();
		f8.getFacility().addAll(Arrays.asList(
				new String[] {"Business center", "Restaurant", "Garden", "Wi fi"} ));
		h8.setFacilities(f8);
		
		hotels.add(h8);
	}
	
	private static void addHotel9() {
		Hotel h9 = new Hotel();
		h9.setId(9);
		h9.setCityName("Sofia");
		h9.setCityId(2);
		h9.setCategory(Category.BUSINESS);
		h9.setName("Grand Hotel Sofia");
		h9.setStars(5);
		h9.setDescription("Set a 5-minute walk from the Serdika Subway Station, the 5-star Grand Hotel Sofia is located right in the heart of Sofia, overlooking the City Garden. It offers large rooms, free Wi-Fi and free indoor parking.The National Theatre, the Bulgarian National bank and all government institutions are just a few steps away from the Grand Hotel Sofia. The closest metro station is a 5-minute walk away.The hotel interior benefits from a unique collection of over 400 original oil paintings. All rooms are air-conditioned and equipped with satellite flat-screen TV. Private bathrooms come with a shower and a bath, as well as a hairdryer, free toiletries, bathrobes and slippers.The Shades of Red gourmet restaurant overlooks the City Garden and offers a wide selection of delights from the international and local cuisine. The Triaditza restaurant features a summer terrace and guests can also enjoy breakfast there. The hotel also provides a private lounge area.The Grand Café with open-air terrace is the ideal venue to enjoy a leisurely cup of coffee, a drink to quench a thirst, or the delights of an extensive pastry menu. With its lush green plants and elegant décor, the terrace provides a magnificent setting for relaxing or enjoying afternoon coffee while watching the world go by.At Grand Hotel Sofia guests can also benefit from using a fitness centre, a health centre and a hairstyle studio. A 24-hour lobby bar, room service, laundry and dry cleaning are also available.Sofia Airport is located 11 km away and the hotel offers a 24-hour airport shuttle service upon request and at a surcharge.");
		h9.setRoomCount(109);
		Contacts c9 = new Contacts();
		c9.setAddress("1, Gourko Str., Sofia, Bulgaria");
		c9.setPhoneNumber("(+359 2) 811 0800");
		h9.setContacts(c9);
		PriceList p9 = new PriceList();
		p9.setSingleRoom(71);
		p9.setDoubleRoom(84);
		p9.setTripleRoom(88);
		h9.setPriceList(p9);
		Facilities f9 = new Facilities();
		f9.getFacility().addAll(Arrays.asList(
				new String[] {"Free parking", "Solarium", "Business center",
						"Hot tub", "Restaurant", "Meeting/Banquet facilities", "Garden",
						"Wi fi", "Sauna", "Bar", "Gift shop", "Fitness center"} ));
		h9.setFacilities(f9);
		
		hotels.add(h9);
	}
	
	private static void addHotel10() {
		Hotel h10 = new Hotel();
		h10.setId(10);
		h10.setCityName("Sofia");
		h10.setCityId(2);
		h10.setCategory(Category.BUSINESS);
		h10.setName("Hotel Vega Sofia");
		h10.setStars(4);
		h10.setDescription("Set a 10-minute drive from the centre of Sofia, hotel Vega offers free WiFi, free fitness centre and free parking. An on-site spa and wellness centre is available at a surcharge.The individually-decorated rooms feature air conditioning, a flat-screen TV with satellite channels and a seating area. The high-quality bed linen is supplemented by anatomical, anti-allergenic or pure cotton pillows. A safety deposit box is provided free of charge. An in-room refreshment centre and a bathroom with a bath and free toiletries are available. All rooms are equipped with a coffee and tea maker and mineral water and hot drinks are complimentary provided.The on-site restaurant offers a wide selection of typical Bulgarian, Mediterranean and vegetarian dishes. A monthly special menu, representing different cuisines from around the globe, is available. The hotel also owns a wine cellar, open for wine tastings.After a long day, guests can relax in the wellness centre, offering massages, a sauna, a solarium and a Turkish Bath. Hotel Vega's bar offers different cocktails.Sofia International Airport can be reached within a 15-minute drive. The G.M.Dimitrov Subway Station is set a 5-minute walk from Hotel Vega.");
		h10.setRoomCount(77);
		Contacts c10 = new Contacts();
		c10.setAddress("75, D-R G.M. Dimitrov Bvld., Sofia, Bulgaria");
		c10.setPhoneNumber("00359 2 806 6000");
		h10.setContacts(c10);
		PriceList p10 = new PriceList();
		p10.setSingleRoom(52);
		p10.setDoubleRoom(59);
		p10.setTripleRoom(95);
		h10.setPriceList(p10);
		Facilities f10 = new Facilities();
		f10.getFacility().addAll(Arrays.asList(
				new String[] {"Free parking", "Solarium", "Business center",
						"Restaurant", "Meeting/Banquet facilities",
						"Wi fi", "Sauna", "Bar", "Gift shop", "Fitness center"} ));
		h10.setFacilities(f10);
		
		hotels.add(h10);
	}
	
	private static void addHotel11() {
		Hotel h11 = new Hotel();
		h11.setId(11);
		h11.setCityName("Plovdiv");
		h11.setCityId(3);
		h11.setCategory(Category.BUSINESS);
		h11.setName("Ramada Plovdiv Trimontium");
		h11.setStars(4);
		h11.setDescription("The sauna and indoor pool create a tranquil vibe at the non-smoking Ramada Plovdiv Trimontium, which is one block from the Opera. All 158 rooms at the mid-rise Trimontium provide guests with mini-fridges, cable TV, free high-speed internet and coffeemakers. Mornings begin with a complimentary breakfast buffet or a dip in the heated indoor pool. Guests relax in the sauna. When duty calls, road warriors head to the business center. The hotel offers an on-site restaurant and room service. Situated in the heart of Plovdiv, the Trimontium is within a five-minute stroll of the Tsar Simeonova Garden. It's one block from the Opera and Philharmonic Society. A 15-minute walk north leads to the Roman Amphitheatre. Stay on the northern path from the hotel to reach the Ethnographic Museum, less than one mile away, and the Maritsa River, just over a mile. A nine-mile drive southeast leads to Plovdiv Airport. For a central Bulgarian location offering a heated pool and free internet, guests make their way to the Ramada Plovdiv Trimontium.");
		h11.setRoomCount(158);
		Contacts c11 = new Contacts();
		c11.setAddress("2 Kapitan Raycho Street, Plovdiv, Bulgaria");
		c11.setPhoneNumber("032 605 000");
		h11.setContacts(c11);
		PriceList p11 = new PriceList();
		p11.setSingleRoom(79);
		p11.setDoubleRoom(87);
		p11.setTripleRoom(96);
		h11.setPriceList(p11);
		Facilities f11 = new Facilities();
		f11.getFacility().addAll(Arrays.asList(
				new String[] {"Swimming pool", "Free parking", "Sauna", "Restaurant",
							"Meeting rooms", "Wi fi", "Beauty shop", "Exercise gym"} ));
		h11.setFacilities(f11);
		
		hotels.add(h11);
	}
	
	private static void addHotel12() {
		Hotel h12 = new Hotel();
		h12.setId(12);
		h12.setCityName("Plovdiv");
		h12.setCityId(3);
		h12.setCategory(Category.BUSINESS);
		h12.setName("Park Hotel Sankt Peterburg");
		h12.setStars(4);
		h12.setDescription("Park Hotel Sankt Peterburg is situated in Plovdiv's business centre and offers elegant accommodation with free Wi-Fi. Plovdiv Ethnographic Museum is 15 minutes' walk away.Park Hotel's rooms are spacious and fitted with luxury bedding. Satellite TV is available in every room. Bathrobes and slippers are also provided.The Sankt Petersburg features an outdoor pool. There is plenty of sun loungers and shaded seating near the pool.Park Hotel Sankt Peterburg is set 1 km away from Plovdiv Railway Station and the International Fair.");
		h12.setRoomCount(198);
		Contacts c12 = new Contacts();
		c12.setAddress("97 Bulgaria Blvd, Plovdiv, Bulgaria");
		c12.setPhoneNumber("+359 32 91 03");
		h12.setContacts(c12);
		PriceList p12 = new PriceList();
		p12.setSingleRoom(36);
		p12.setDoubleRoom(45);
		p12.setTripleRoom(50);
		h12.setPriceList(p12);
		Facilities f12 = new Facilities();
		f12.getFacility().addAll(Arrays.asList(
				new String[] {"Garden","Outdoor pool", "Free parking", "Bar", "Restaurant",
							"Meeting/Banquet facilities", "Wi fi", "Beauty shop",
							"Gift shop", "Water park", "Business center"} ));
		h12.setFacilities(f12);
		
		hotels.add(h12);
	}
	
	private static void addHotel13() {
		Hotel h13 = new Hotel();
		h13.setId(13);
		h13.setCityName("Pazardzhik");
		h13.setCityId(7);
		h13.setCategory(Category.SPA);
		h13.setName("Grand Hotel Hebar");
		h13.setStars(4);
		h13.setDescription("Grand Hotel Hebar is a large luxury hotel conveniently situated in the heart of Pazardzhik. It features a restaurant and a fitness centre and free WiFi throughout the hotel.All guest rooms feature a flat-screen flat-screen TV with cable channels and en-suite bathroom. In addition every room has a telephone, a minibar and a safety deposit box.The hotel's restaurant serves a continental breakfast, and a diverse menu for lunch and dinner. It is a suitable destination for any occasion, whether a family celebration or a business meeting. There is a separate VIP room in the restaurant.The Grand Hotel has a fitness centre and a sauna, which the guests can use free of charge, and a gift shop is also available.Within a few minutes' walk of the hotel is the Museum of History.Snezhanka cave is reachable within a 15-minute drive. Grand Hotel Hebar is a 30-minute drive from Plovdiv and its famous fairgrounds. Sofia and the Vrazhdebna Airport are 100 km away. ");
		h13.setRoomCount(57);
		Contacts c13 = new Contacts();
		c13.setAddress("6 Esperanto Str., Pazardzhik, Bulgaria");
		c13.setPhoneNumber("+359 896 66 66 44");
		h13.setContacts(c13);
		PriceList p13 = new PriceList();
		p13.setSingleRoom(61);
		p13.setDoubleRoom(77);
		p13.setTripleRoom(89);
		h13.setPriceList(p13);
		Facilities f13 = new Facilities();
		f13.getFacility().addAll(Arrays.asList(
				new String[] {"Free parking", "Bar", "Restaurant", "Meeting/Banquet facilities",
							"Wi fi", "Gift shop", "Fitness center"} ));
		h13.setFacilities(f13);
		
		hotels.add(h13);
	}
	
	private static void addHotel14() {
		Hotel h14 = new Hotel();
		h14.setId(14);
		h14.setCityName("Pazardzhik");
		h14.setCityId(7);
		h14.setCategory(Category.FAMILY);
		h14.setName("Elbrus Hotel");
		h14.setStars(2);
		h14.setDescription("This hotel is located in the centre of Pazardzhik, 800 metres from Pazardnik Cathedral and the Pazardzhik History Museum. Hotel Elbrus offers a 24-hour reception and free Wi-Fi in public areas.Rooms at the Elbrus Hotel are simply furnished. All rooms are air-conditioned and include a TV, refrigerator and private bathroom.A continental breakfast is provided each morning at the Elbrus. Traditional Bulgarian cuisine is also served, and room service is available.  Guests are also welcome to relax at the bar.Hotel Elbrus is a 10-minute drive from Pazardzhik Bus and Train Stations. On-site parking is free and Plovdiv is a 40-minute drive away via the A1 motorway. ");
		h14.setRoomCount(80);
		Contacts c14 = new Contacts();
		c14.setAddress("Konstantin Velichkov 1, Pazardzhik, Bulgaria");
		c14.setPhoneNumber("(034) 440 850");
		h14.setContacts(c14);
		PriceList p14 = new PriceList();
		p14.setSingleRoom(27);
		p14.setDoubleRoom(40);
		p14.setTripleRoom(54);
		h14.setPriceList(p14);
		Facilities f14 = new Facilities();
		f14.getFacility().addAll(Arrays.asList(
				new String[] {"Bar", "Restaurant", "Wi fi", "Beauty shop"} ));
		h14.setFacilities(f14);
		
		hotels.add(h14);
	}
	
	private static void addHotel15() {
		Hotel h15 = new Hotel();
		h15.setId(15);
		h15.setCityName("Pazardzhik");
		h15.setCityId(7);
		h15.setCategory(Category.FAMILY);
		h15.setName("Trakia Street Apartment");
		h15.setStars(2);
		h15.setDescription("Set 800 metres from Roman Theatre Plovdiv in Plovdiv, this air-conditioned apartment features free WiFi and a terrace. Guests benefit from balcony and a sun terrace. Free private parking is available on site.The kitchen comes with a dishwasher. A TV is provided. There is a private bathroom with a hot tub and bath.International Fair Plovdiv is 2.2 km from Trakia Street Apartment, while Plovdiv Municipality is 800 metres from the property.");
		h15.setRoomCount(20);
		Contacts c15 = new Contacts();
		c15.setAddress("26 Trakia Street, Pazardzhik, Bulgaria");
		c15.setPhoneNumber("(034) 123 456");
		h15.setContacts(c15);
		PriceList p15 = new PriceList();
		p15.setSingleRoom(37);
		p15.setDoubleRoom(38);
		p15.setTripleRoom(40);
		h15.setPriceList(p15);
		Facilities f15 = new Facilities();
		f15.getFacility().addAll(Arrays.asList(
				new String[] {"Garden", "Table tennis", "Private parking",
							"Sun terrace", "Wi fi"} ));
		h15.setFacilities(f15);
		
		hotels.add(h15);
	}
}
