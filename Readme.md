# Meetings Winforms Appp

# Remark

Intended to be an alternative to JSON and YAML and XML.

The prime motivation was to just be able to write/control meetings in a forward-only manner. None of this Jira back and forth.

Basic syntax: use indents. Spaces or tabs.

```remark
Heading
    Idea1
        Some details
    Idea2
        Some other details
        Even more details
    Idea3
        Use [Idea1](#Idea1) as a basis to re-write [google](www.google.com).

```

## Motivation

Markdown is awesome. I wrote my Will in Markdown, and use for *documentation* whenever I can.

But for data? No. So then what. JSON? XML? YAML? Basic [config] files? I happen to hate JSON and don't love YAML. We all know about XML.

`Remark` was designed to be as quick and simple to write and parse as possible. The original motivation was for writing issues for meeting. Example:

```
Agenda
    We have to get shit done by Monday
    Re-assign tickets to align for this
        Paul is sick
Goal
    Foo has to comply to [Req19](www.some.link/req19) by next Monday
Re-assign
    Anyone not working on the goal has to stop work, and re-assign
        We will cover the mess in next meeting
```

I can feed this into a `WinForms` (!) app and just go through each stage, with timers on each as well.

Markdown is hierachical. `Remark` is not: it is a series of items to be addressed in a short period of time. Both in creation and practical use in meetings.

