using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x020001FB RID: 507
	[Token(Token = "0x20001FB")]
	[AddComponentMenu("Sons/Stimuli/Waypoint Clusters Stimuli")]
	[RequireComponent(typeof(PointGenerator))]
	public class WaypointClustersStimuli : ZoneStimuli
	{
		// Token: 0x06000EA8 RID: 3752 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000EA8")]
		[Address(RVA = "0x2BAF350", Offset = "0x2BAD950", VA = "0x182BAF350")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000EA9")]
		[Address(RVA = "0x2BAF380", Offset = "0x2BAD980", VA = "0x182BAF380")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000EAA RID: 3754 RVA: 0x00008358 File Offset: 0x00006558
		[Token(Token = "0x6000EAA")]
		[Address(RVA = "0x2BAF400", Offset = "0x2BADA00", VA = "0x182BAF400", Slot = "12")]
		public override bool Validate(VailActor vailActor)
		{
			return default(bool);
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EAB")]
		[Address(RVA = "0x1243280", Offset = "0x1241880", VA = "0x181243280")]
		public WaypointClustersStimuli()
		{
		}

		// Token: 0x040008FE RID: 2302
		[Token(Token = "0x40008FE")]
		[FieldOffset(Offset = "0xD0")]
		public VailActorTypeId _validActorType;
	}
}
