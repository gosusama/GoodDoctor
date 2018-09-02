import React, { Component } from 'react';
import { Text, View } from 'react-native';
import { createStackNavigator } from 'react-navigation';
import State from './src/app/State'


export default class GoodDoctorApp extends Component {
  render() {
    return (
      <State/>
    );
  }
}