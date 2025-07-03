import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { CheckHeaderComponent } from './check-header/check-header.component';
import { LoginComponent } from './login/login.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [LoginComponent, CheckHeaderComponent, RouterOutlet],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'ang18test';
}
