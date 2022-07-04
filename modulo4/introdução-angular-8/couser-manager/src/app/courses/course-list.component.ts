import { Component, OnInit } from "@angular/core";
import { Course } from "./course";
import { CourseService } from "./course.service";

@Component({
    templateUrl: './course-list.component.html'
})
export class CourseListComponent implements OnInit {
    _courses: Course[] = [];
    _filterBy: string = "";
    filteredCourses: Course[] = [];

    constructor(private courseService: CourseService) { }

    ngOnInit(): void {
        this.retriveAll();
    }

    retriveAll(): void {
        this.courseService.retriveAll().subscribe({
            next: (courses: any) => {
                this._courses = courses;
                this.filteredCourses = this._courses;
            },
            error: (err: any) => console.log('Erro', err)
        })
    }

    deleteById(courseId: number): void {
        this.courseService.deleteById(courseId).subscribe({
            next: () => {
                console.log('Deleted with success');
                this.retriveAll();
            },
            error: (err: any) => console.log('Erro', err)
        })
    }

    get filter() {
        return this._filterBy;
    }
    set filter(value: string) {
        this._filterBy = value;
        this.filteredCourses = this._courses.filter(
            (course: Course) => course.name.toLocaleLowerCase().indexOf(this._filterBy.toLocaleLowerCase()) > - 1);
    }
}