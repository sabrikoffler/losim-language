package org.simol.examples.design_patterns.mvc;public class WeatherModel{private String location;private String forecast;public void setLocation(String location){this.location=location;}public void fetchWeather(){this.forecast="Sunny with a chance of clouds";}public String getForecast(){return forecast;}}