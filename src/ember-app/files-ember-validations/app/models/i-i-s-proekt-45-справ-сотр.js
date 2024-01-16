import {
  defineNamespace,
  defineProjections,
  Model as СправСотрMixin
} from '../mixins/regenerated/models/i-i-s-proekt-45-справ-сотр';

import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

let Model = EmberFlexberryDataModel.extend(СправСотрMixin, {
});

defineNamespace(Model);
defineProjections(Model);

export default Model;
