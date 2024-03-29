import { moduleForModel, test } from 'ember-qunit';

moduleForModel('i-i-s-proekt-45-расписание', 'Unit | Model | i-i-s-proekt-45-расписание', {
  // Specify the other units that are required for this test.
  needs: [
    'model:i-i-s-proekt-45-класс-уч',
    'model:i-i-s-proekt-45-номер',
    'model:i-i-s-proekt-45-приход-уход',
    'model:i-i-s-proekt-45-просмотр',
    'model:i-i-s-proekt-45-расписание',
    'model:i-i-s-proekt-45-справ-долж',
    'model:i-i-s-proekt-45-справ-род',
    'model:i-i-s-proekt-45-справ-сотр',
    'model:i-i-s-proekt-45-справ-уч',
    'model:i-i-s-proekt-45-ученик',
    'validator:ds-error',
    'validator:presence',
    'validator:number',
    'validator:date',
    'validator:belongs-to',
    'validator:has-many',
    'service:syncer',
  ],
});

test('it exists', function(assert) {
  let model = this.subject();

  // let store = this.store();
  assert.ok(!!model);
});
