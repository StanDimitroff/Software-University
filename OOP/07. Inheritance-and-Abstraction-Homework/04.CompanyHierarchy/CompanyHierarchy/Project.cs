﻿using System;

public class Project : IProject
{
    private string projectName;
    private DateTime startDate;
    private string details;
    private State state;

    public Project(string projectName, DateTime startDate, string details, State state)
    {
        this.ProjectName = projectName;
        this.StartDate = startDate;
        this.Details = details;
        this.State = state;
    }

    public string ProjectName
    {
        get
        {
            return this.projectName;
        }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(
                    "projectName", "Project Name can not be null or empty!");
            }

            this.projectName = value;
        }
    }

    public DateTime StartDate
    {
        get { return this.startDate; }
        set { this.startDate = value; }
    }

    public string Details
    {
        get
        {
            return this.details;
        }

        set
        {
            if (value == string.Empty)
            {
                throw new ArgumentException("Details can not be empty text!", "details");
            }

            this.details = value;
        }
    }

    public State State
    {
        get { return this.state; }
        set { this.state = value; }
    }

    public void CloseProject()
    {
        this.State = State.Closed;
    }

    public override string ToString()
    {
        return string.Format("Project Name:{0}, Start Date:{1:dd-MM-yyyy}, Details:{2}, State:{3}", this.ProjectName, this.StartDate, this.Details, this.State);
    }
}