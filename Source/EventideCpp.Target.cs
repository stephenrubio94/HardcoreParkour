// Copyright sucks

using UnrealBuildTool;
using System.Collections.Generic;

public class EventideCppTarget : TargetRules
{
	public EventideCppTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "EventideCpp" } );
	}
}
