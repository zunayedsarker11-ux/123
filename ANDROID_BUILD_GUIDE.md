# Android Build Guide for Google Play Store Deployment

## Overview
This guide provides comprehensive instructions for building an Android application for deployment on the Google Play Store. It covers player settings, build configuration, icon requirements, and app store listing assets.

## Player Settings
- Open your project in Unity.
- Go to `Edit` > `Project Settings` > `Player`.
- **Android Settings:**
  - Company Name: Your Company Name
  - Product Name: Your App Name
  - Package Name: `com.yourcompany.yourapp`
  - Minimum API Level: Select based on your target audience (e.g., API Level 21 or higher)

## Build Configuration
1. **Build Settings:**
   - Open `File` > `Build Settings`.
   - Select `Android` and click on `Switch Platform`.

2. **Player Settings:**
   - In the Player Settings, select the `Android` tab and ensure the following:
     - **Version:** Set your app version (e.g., 1.0.0)
     - **Bundle Version Code:** Increment this with each release (e.g., 1)
     - **Scripting Backend:** IL2CPP is recommended for better performance.
     - **Target Architectures:** Select ARMv7 and ARM64.

3. **Keystore Setup:**
   - Create a keystore file using the keytool command:
     ```bash
     keytool -genkey -v -keystore your-keystore.jks -keyalg RSA -keysize 2048 -validity 10000 -alias your-key-alias
     ```
   - Fill in the necessary details during the keystore creation process.

4. **Build the App:**
   - Click on `Build` and select a destination folder to save your APK file.

## Icon Requirements
- **App Icon:** Must be a square PNG image.
  - Recommended size: 512x512 pixels
  - Provide different resolutions in the following dimensions:
    - 48x48 pixels (mdpi)
    - 72x72 pixels (hdpi)
    - 96x96 pixels (xhdpi)
    - 144x144 pixels (xxhdpi)
    - 192x192 pixels (xxxhdpi)

## App Store Listing Assets
1. **Feature Graphic:**
   - Size: 1024x500 pixels
   - Format: JPEG or 24-bit PNG (no alpha)

2. **Screenshots:**
   - Minimum of 2 screenshots of your app that show functionality.
   - Recommended sizes: 1280x720 pixels or larger for phone, and 1280x800 pixels for tablet.

3. **Promo Graphic (Optional):**
   - Size: 180 x 120 pixels (only for promotions)
   - Format: JPEG or 24-bit PNG (no alpha)

4. **Description:**
   - Write a short and long description of your app that describes its features and functionalities effectively.

## Final Steps
- Test your APK thoroughly for any bugs or issues.
- Prepare your app store listing with all necessary assets.
- Submit your app for review to the Google Play Store and monitor the approval process.