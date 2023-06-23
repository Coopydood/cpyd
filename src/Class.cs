using System;
using System.Collections.Generic;

namespace cypd.DataTypes;

class Class {

    private List<float> grades;
    public string name;

    public Class(string name) {
        if (name == null) {

            throw new ArgumentNullException(nameof(name));


        }
        this.name = name;
        grades = new List<float>();
    }

    public void AddGrade(float grade) {
        grades.Add(grade);
    }

    public float GetAverageGrade() {
        float sum = 0;
        foreach (float grade in grades) {
            sum += grade;
        }
        return sum / grades.Count;
    }

}