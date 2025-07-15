import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'LocalizationAndAuthGuard',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44363/',
    redirectUri: baseUrl,
    clientId: 'LocalizationAndAuthGuard_App',
    responseType: 'code',
    scope: 'offline_access LocalizationAndAuthGuard',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44363',
      rootNamespace: 'Repro.LocalizationAndAuthGuard',
    },
  },
} as Environment;
