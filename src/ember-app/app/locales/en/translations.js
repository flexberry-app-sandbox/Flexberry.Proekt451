import $ from 'jquery';
import EmberFlexberryTranslations from 'ember-flexberry/locales/en/translations';

import IISProekt_45КлассУчLForm from './forms/i-i-s-proekt-45-класс-уч-l';
import IISProekt_45НомерLForm from './forms/i-i-s-proekt-45-номер-l';
import IISProekt_45ПриходУходLForm from './forms/i-i-s-proekt-45-приход-уход-l';
import IISProekt_45ПросмотрLForm from './forms/i-i-s-proekt-45-просмотр-l';
import IISProekt_45РасписаниеLForm from './forms/i-i-s-proekt-45-расписание-l';
import IISProekt_45СправДолжLForm from './forms/i-i-s-proekt-45-справ-долж-l';
import IISProekt_45СправРодLForm from './forms/i-i-s-proekt-45-справ-род-l';
import IISProekt_45СправСотрLForm from './forms/i-i-s-proekt-45-справ-сотр-l';
import IISProekt_45СправУчLForm from './forms/i-i-s-proekt-45-справ-уч-l';
import IISProekt_45КлассУчEForm from './forms/i-i-s-proekt-45-класс-уч-e';
import IISProekt_45НомерEForm from './forms/i-i-s-proekt-45-номер-e';
import IISProekt_45ПриходУходEForm from './forms/i-i-s-proekt-45-приход-уход-e';
import IISProekt_45ПросмотрEForm from './forms/i-i-s-proekt-45-просмотр-e';
import IISProekt_45РасписаниеEForm from './forms/i-i-s-proekt-45-расписание-e';
import IISProekt_45СправДолжEForm from './forms/i-i-s-proekt-45-справ-долж-e';
import IISProekt_45СправРодEForm from './forms/i-i-s-proekt-45-справ-род-e';
import IISProekt_45СправСотрEForm from './forms/i-i-s-proekt-45-справ-сотр-e';
import IISProekt_45СправУчEForm from './forms/i-i-s-proekt-45-справ-уч-e';
import IISProekt_45КлассУчModel from './models/i-i-s-proekt-45-класс-уч';
import IISProekt_45НомерModel from './models/i-i-s-proekt-45-номер';
import IISProekt_45ПриходУходModel from './models/i-i-s-proekt-45-приход-уход';
import IISProekt_45ПросмотрModel from './models/i-i-s-proekt-45-просмотр';
import IISProekt_45РасписаниеModel from './models/i-i-s-proekt-45-расписание';
import IISProekt_45СправДолжModel from './models/i-i-s-proekt-45-справ-долж';
import IISProekt_45СправРодModel from './models/i-i-s-proekt-45-справ-род';
import IISProekt_45СправСотрModel from './models/i-i-s-proekt-45-справ-сотр';
import IISProekt_45СправУчModel from './models/i-i-s-proekt-45-справ-уч';
import IISProekt_45УченикModel from './models/i-i-s-proekt-45-ученик';

const translations = {};
$.extend(true, translations, EmberFlexberryTranslations);

$.extend(true, translations, {
  models: {
    'i-i-s-proekt-45-класс-уч': IISProekt_45КлассУчModel,
    'i-i-s-proekt-45-номер': IISProekt_45НомерModel,
    'i-i-s-proekt-45-приход-уход': IISProekt_45ПриходУходModel,
    'i-i-s-proekt-45-просмотр': IISProekt_45ПросмотрModel,
    'i-i-s-proekt-45-расписание': IISProekt_45РасписаниеModel,
    'i-i-s-proekt-45-справ-долж': IISProekt_45СправДолжModel,
    'i-i-s-proekt-45-справ-род': IISProekt_45СправРодModel,
    'i-i-s-proekt-45-справ-сотр': IISProekt_45СправСотрModel,
    'i-i-s-proekt-45-справ-уч': IISProekt_45СправУчModel,
    'i-i-s-proekt-45-ученик': IISProekt_45УченикModel
  },

  'application-name': 'Proekt_45',

  forms: {
    loading: {
      'spinner-caption': 'Loading stuff, please wait for a moment...'
    },
    index: {
      greeting: 'Welcome to ember-flexberry test stand!'
    },

    application: {
      header: {
        menu: {
          'sitemap-button': {
            title: 'Menu'
          },
          'user-settings-service-checkbox': {
            caption: 'Use service to save user settings'
          },
          'show-menu': {
            caption: 'Show menu'
          },
          'hide-menu': {
            caption: 'Hide menu'
          },
          'language-dropdown': {
            caption: 'Application language',
            placeholder: 'Choose language'
          }
        },
        login: {
          caption: 'Login'
        },
        logout: {
          caption: 'Logout'
        }
      },

      footer: {
        'application-name': 'Proekt_45',
        'application-version': {
          caption: 'Addon version {{version}}',
          title: 'It is version of ember-flexberry addon, which uses in this dummy application ' +
          '(npm version + commit sha). ' +
          'Click to open commit on GitHub.'
        }
      },

      sitemap: {
        'application-name': {
          caption: 'Proekt_45',
          title: 'Proekt_45'
        },
        'application-version': {
          caption: 'Addon version {{version}}',
          title: 'It is version of ember-flexberry addon, which uses in this dummy application ' +
          '(npm version + commit sha). ' +
          'Click to open commit on GitHub.'
        },
        index: {
          caption: 'Home',
          title: ''
        },
        администратор: {
          caption: 'Администратор',
          title: 'Администратор',
          'i-i-s-proekt-45-расписание-l': {
            caption: 'Расписание',
            title: ''
          },
          'i-i-s-proekt-45-класс-уч-l': {
            caption: 'Класс ученика',
            title: ''
          },
          'i-i-s-proekt-45-справ-долж-l': {
            caption: 'Справочник должности',
            title: ''
          },
          'i-i-s-proekt-45-справ-уч-l': {
            caption: 'Справочник ученики',
            title: ''
          },
          'i-i-s-proekt-45-справ-род-l': {
            caption: 'Справочник родители',
            title: ''
          },
          'i-i-s-proekt-45-справ-сотр-l': {
            caption: 'Справочник сотрудники',
            title: ''
          },
          'i-i-s-proekt-45-номер-l': {
            caption: 'Номер карты',
            title: ''
          }
        },
        ученик: {
          caption: 'Ученик',
          title: 'Ученик',
          'i-i-s-proekt-45-приход-уход-l': {
            caption: 'Функция: регистрация прихода/ухода ученика',
            title: 'Приход уход'
          }
        },
        родители: {
          caption: 'Родители',
          title: 'Родители',
          'i-i-s-proekt-45-просмотр-l': {
            caption: 'Функция: контроль и просмотр прихода/ухода ученика',
            title: 'Просмотр'
          }
        }
      }
    },

    'edit-form': {
      'save-success-message-caption': 'Save operation succeed',
      'save-success-message': 'Object saved',
      'save-error-message-caption': 'Save operation failed',
      'delete-success-message-caption': 'Delete operation succeed',
      'delete-success-message': 'Object deleted',
      'delete-error-message-caption': 'Delete operation failed'
    },
    'i-i-s-proekt-45-класс-уч-l': IISProekt_45КлассУчLForm,
    'i-i-s-proekt-45-номер-l': IISProekt_45НомерLForm,
    'i-i-s-proekt-45-приход-уход-l': IISProekt_45ПриходУходLForm,
    'i-i-s-proekt-45-просмотр-l': IISProekt_45ПросмотрLForm,
    'i-i-s-proekt-45-расписание-l': IISProekt_45РасписаниеLForm,
    'i-i-s-proekt-45-справ-долж-l': IISProekt_45СправДолжLForm,
    'i-i-s-proekt-45-справ-род-l': IISProekt_45СправРодLForm,
    'i-i-s-proekt-45-справ-сотр-l': IISProekt_45СправСотрLForm,
    'i-i-s-proekt-45-справ-уч-l': IISProekt_45СправУчLForm,
    'i-i-s-proekt-45-класс-уч-e': IISProekt_45КлассУчEForm,
    'i-i-s-proekt-45-номер-e': IISProekt_45НомерEForm,
    'i-i-s-proekt-45-приход-уход-e': IISProekt_45ПриходУходEForm,
    'i-i-s-proekt-45-просмотр-e': IISProekt_45ПросмотрEForm,
    'i-i-s-proekt-45-расписание-e': IISProekt_45РасписаниеEForm,
    'i-i-s-proekt-45-справ-долж-e': IISProekt_45СправДолжEForm,
    'i-i-s-proekt-45-справ-род-e': IISProekt_45СправРодEForm,
    'i-i-s-proekt-45-справ-сотр-e': IISProekt_45СправСотрEForm,
    'i-i-s-proekt-45-справ-уч-e': IISProekt_45СправУчEForm
  },

});

export default translations;
