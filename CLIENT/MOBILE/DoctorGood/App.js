import React, { Component } from 'react';
import { Text, View } from 'react-native';
import { createStackNavigator } from 'react-navigation';
import LoginScreen from './src/app/components/screens/LoginScreen';
import HomeScreen from './src/app/components/screens/HomeScreen';


export default class GoodDoctorApp extends Component {
  render() {
    return (
      <RootStack/>
    );
  }
}
const RootStack = createStackNavigator(
  {
    Login: {
      screen: LoginScreen,
    },
    Home: {
      screen: HomeScreen,
    },
  }, {
    initialRouteName: 'Login',
  }
)