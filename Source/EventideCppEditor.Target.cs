// Copyright sucks

using UnrealBuildTool;
using System.Collections.Generic;

public class EventideCppEditorTarget : TargetRules
{
	public EventideCppEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "EventideCpp" } );
	}
}
