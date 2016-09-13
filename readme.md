# Execution Order testing Unity (5.4.0)

It wasn't clear which dependent Unity [Components](https://docs.unity3d.com/Manual/Components.html) executed first. This very simple project helps determine that.

Some conclusions

 * [Execution Order](https://docs.unity3d.com/Manual/ExecutionOrder.html) affects all instances of a given script (Component) in the entire [scene](https://docs.unity3d.com/Manual/CreatingScenes.html).
 * E.g. GameObject One and GameObject Zero both have Script.cs and Foo.cs attached, and have print statements in their alternative "constructors" (Awake and Start). Simply running will show in the [console](https://docs.unity3d.com/Manual/Console.html) that all Scripts Awakes will occur before all Foo Awakes, and subsequently the same for Starts.
 * E.g. The GameObject God has a main script Godo.cs, which further finds or adds other scripts (Components). It first tries to GetComponent<Thingymabob>(), which DOES print the REFERENCE to that name, but DOESN'T EXECUTE that script's Awake or Start methods. Interestingly by using AddComponent<Jigglyboby>(), it DOES EXECUTE that Awake and Start immediately. Finally Thingymabob's Awake/Starts do execute.... eventually afterwards.