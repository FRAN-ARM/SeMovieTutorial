﻿
namespace SeMovieTutorial.BasicSamples {

    @Serenity.Decorators.registerClass()
    export class DragDropSampleDialog extends Serenity.EntityDialog<DragDropSampleRow, any> {
        protected getFormKey() { return DragDropSampleForm.formKey; }
        protected getIdProperty() { return DragDropSampleRow.idProperty; }
        protected getLocalTextPrefix() { return DragDropSampleRow.localTextPrefix; }
        protected getNameProperty() { return DragDropSampleRow.nameProperty; }
        protected getService() { return DragDropSampleService.baseUrl; }

        protected form = new DragDropSampleForm(this.idPrefix);

    }
}