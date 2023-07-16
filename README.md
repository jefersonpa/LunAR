
<p align="center">
  <!--<picture>
    <source media="(prefers-color-scheme: dark)" srcset="logourldark">
    <img src="logourl" height="128">
  </picture>-->
  <h1 align="center">LunAR</h1>
  <p align="center">
    Lunar is an innovative software application that utilizes AR technology to provide a seamless and immersive experience for viewing IFC models.
  </p>
</p>

<p align="center">
  <a target="_blank" href="https://unity.com"><img alt="Unity 2022.3.3" src="https://img.shields.io/badge/unity-2022.3.3-000?style=for-the-badge&logo=unity&logoColor=white&color=444&labelColor=000"></a>
  <a target="_blank" href="https://reactnative.dev/"><img alt="React Native 0.72.3" src="https://img.shields.io/badge/react_native-0.72.3-000?style=for-the-badge&logo=react&logoColor=white&color=444&labelColor=000"></a>
  <a target="_blank" href="https://docs.unity3d.com/Packages/com.unity.xr.arfoundation@5.0/manual/index.html"><img alt="AR Foundation 5.0.6" src="https://img.shields.io/badge/AR%20Foundation-5.0.6-%25fff?style=for-the-badge&logo=googlecardboard&logoColor=fff&color=444&labelColor=000"></a>
</p>

<p align="center">
  <a target="_blank" href="https://www.android.com/"><img alt="Android" src="https://img.shields.io/badge/Android-000?style=for-the-badge&logo=android&logoColor=white"></a>
  <a target="_blank" href="https://www.apple.com/ios/ios-16/"><img alt="IOS" src="https://img.shields.io/badge/iOS-000?style=for-the-badge&logo=ios&logoColor=white"></a>
</p>

<h3>Getting Started</h3> 
<p>
  <b>Installation:</b> This app uses <a target="_blank" href="https://github.com/azesmway/react-native-unity">react-native-unity</a> to link between the react-native project and the unity project, so you will probably need to configure the unity environment. The easiest way to do this is by following the steps in <a target="_blank" href="https://medium.com/@salaheddine.ly/part-i-integrating-unity-games-to-react-native-apps-for-beginners-for-android-4c48031e2829">this tutorial</a>.
  <br>
  <b>Launch:</b> Go to the lunar folder and run the command:
  
```
$ npm install
$ npm start
```

</p>
<h3>Project structure</h3> <!-- (gitree) --> 

    ├── LICENSE
    ├── lunar                        # react-native project
    │   ├── android                  # Android build
    │   ├── app.json
    │   ├── App.tsx
    │   ├── babel.config.js
    │   ├── Gemfile
    │   ├── index.js
    │   ├── ios                      # IOS build
    │   ├── jest.config.js
    │   ├── metro.config.js
    │   ├── package-lock.json
    │   ├── package.json
    │   ├── tsconfig.json
    │   └── UnityApp.tsx
    ├── README.md
    └── unity                        # Unity project
        └── lunar
