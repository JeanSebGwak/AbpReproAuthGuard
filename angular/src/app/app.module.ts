import { provideAccountConfig } from '@abp/ng.account/config';
import { CoreModule, provideAbpCore, withOptions } from '@abp/ng.core';
import { registerLocale } from '@abp/ng.core/locale';
import { provideFeatureManagementConfig } from '@abp/ng.feature-management';
import { provideIdentityConfig } from '@abp/ng.identity/config';
import { provideAbpOAuth } from '@abp/ng.oauth';
import { provideSettingManagementConfig } from '@abp/ng.setting-management/config';
import { provideTenantManagementConfig } from '@abp/ng.tenant-management/config';
import { ThemeBasicModule, provideThemeBasicConfig } from '@abp/ng.theme.basic';
import {
  InternetConnectionStatusComponent,
  ThemeSharedModule,
  provideAbpThemeShared,
  withValidationBluePrint,
} from '@abp/ng.theme.shared';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { environment } from '../environments/environment';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { APP_ROUTE_PROVIDER } from './route.provider';
@NgModule({
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    CoreModule,
    InternetConnectionStatusComponent,
    ThemeBasicModule,
    ThemeSharedModule,
  ],
  declarations: [AppComponent],
  providers: [
    APP_ROUTE_PROVIDER,
    provideAbpCore(
      withOptions({
        environment,
        registerLocaleFn: registerLocale(),
      })
    ),
    provideAbpOAuth(),
    provideSettingManagementConfig(),
    provideAccountConfig(),
    provideIdentityConfig(),
    provideTenantManagementConfig(),
    provideFeatureManagementConfig(),
    provideThemeBasicConfig(),
    provideAbpThemeShared(
      withValidationBluePrint({
        wrongPassword: 'Please choose 1q2w3E*',
      })
    ),
  ],
  bootstrap: [AppComponent],
})
export class AppModule {}
