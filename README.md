# BrowerBlazorGraph

Basic Blazor graph component with a rendering test. Overrides ShouldRender with a model object that is watched by an observer to detect changes for improved rendering. Total render calls in past 150ms shown in graph increments.

![image](https://github.com/camelCase12/BrowerBlazorGraph/assets/14899204/04cc5035-a753-4513-b705-6125efa3da68)

This is a graph of rendering calls per second. The peaks show default rendering, while the troughs show my rendering implementation.
