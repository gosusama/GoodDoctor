import React, { Component } from 'react';
import { Text, View, StyleSheet } from 'react-native';
import {createStackNavigator} from 'react-navigation';

export default class LoginNavigator extends Component {
    render() {
        return (
            <LoginStack/>
        );
    }
}

class LoginScreen extends Component {
    render() {
        return (
            <Text>LoginScreena</Text>
        );
    }
}

const LoginStack = createStackNavigator(
    {
        Login: {
            screen: LoginScreen,
        }, 
    }, {
        initialRouteName: 'Login',
    }
)