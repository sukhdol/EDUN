import {Component, OnInit} from '@angular/core';
import { ItemsService } from 'src/app/services/items.service';

@Component({
  selector: 'app-item-form',
  templateUrl: './item-form.component.html',
})
export class ItemFormComponent implements OnInit {

  constructor(private itemsServie: ItemsService) {
  }

  ngOnInit() {
  }
}
