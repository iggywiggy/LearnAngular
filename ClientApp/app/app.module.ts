import {BrowserModule} from "@angular/platform-browser";
import {NgModule} from "@angular/core";
import {FormsModule} from "@angular/forms";
import {HttpModule} from "@angular/http";
import {AppComponent} from "./app.component";
import {ModelModule} from "./models/model.module";
import {HttpClientModule} from "@angular/common/http";
import {Repository} from "./models/repository";


@NgModule({
    declarations: [AppComponent],
    imports: [HttpClientModule, BrowserModule, FormsModule, HttpModule, ModelModule],
    providers: [Repository],
    bootstrap: [AppComponent]
})
export class AppModule {
}