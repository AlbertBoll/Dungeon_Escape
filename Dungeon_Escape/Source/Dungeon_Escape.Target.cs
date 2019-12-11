// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Dungeon_EscapeTarget : TargetRules
{
	public Dungeon_EscapeTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "Dungeon_Escape" } );
	}
}
