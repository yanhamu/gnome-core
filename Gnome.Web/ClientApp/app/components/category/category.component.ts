import { Component } from '@angular/core';
import { TreeModel, NodeEvent } from 'ng2-tree';

@Component({
    selector: 'category',
    templateUrl: './category.component.html'
})
export class CategoryComponent {
    public tree: TreeModel = {
        value: 'Programming languages by programming paradigm',
        children: [
            {
                value: 'Object-oriented programming',
                children: [
                    { value: 'Java' },
                    { value: 'C++' },
                    { value: 'C#' },
                ]
            },
            {
                value: 'Prototype-based programming',
                children: [
                    { value: 'JavaScript' },
                    { value: 'CoffeeScript' },
                    { value: 'Lua' },
                ]
            }
        ]
    };

    public logEvent(e: NodeEvent): void {
        console.log(e);
    };
}