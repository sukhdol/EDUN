import { CategoryItem } from './../../models/category-items';
import {Component, OnInit} from '@angular/core';
import { CategoriesService } from 'src/app/services/categories.service';
import { ItemsService } from 'src/app/services/items.service';

@Component({
  selector: 'app-category-items',
  templateUrl: './category-items-list.component.html',
  // styleUrls: ['./category-items-list.component.css']
})
export class CategoryItemsListComponent implements OnInit {
  catItemList = new Array<CategoryItem>();
  grandTotal: number;

  constructor(private categoriesService: CategoriesService,
              private itemsServie: ItemsService) {
  }

  ngOnInit() {
    this.getCategories();
  }

  deleteItem(id) {
    if (confirm('Are you sure?'))
    {
      this.itemsServie.delete(id).subscribe(x => {
        this.getCategories();
      });
    }
  }

  getCategories() {
    this.catItemList = new Array<CategoryItem>();
    this.categoriesService.getCategoryItemsList().subscribe(cat => {
      this.grandTotal = 0;
      cat.forEach(ct => {
        let catItem = new CategoryItem(ct);
        this.catItemList.push(catItem);
        this.grandTotal += catItem.total;
      });
    });
  }
}
