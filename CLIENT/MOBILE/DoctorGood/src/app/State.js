import React, { Component } from 'react';
import { Text, View } from 'react-native';
import { createStackNavigator } from 'react-navigation';
import LoginScreen from './components/screens/LoginScreen';
import HomeScreen from './components/screens/HomeScreen';

export default class State extends Component {
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