import React, { Component } from 'react';
import { Text, View, SafeAreaView } from 'react-native';
import { createStackNavigator } from 'react-navigation';
import LoginNavigator from './components/screens/LoginScreen';
import HomeScreen from './components/screens/HomeScreen';

export default class State extends Component {
  render() {
    return (
      <SafeAreaView>
        <RootStack />
      </SafeAreaView>
    );
  }
}
const RootStack = createStackNavigator(
  {
    Login: {
      screen: LoginNavigator,
    },
    Home: {
      screen: HomeScreen,
    },
  }, {
    initialRouteName: 'Login',
  }
)