using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x020001CC RID: 460
	[Token(Token = "0x20001CC")]
	[AddComponentMenu("Sons/Stimuli/Player Structure Stimuli")]
	public class PlayerStructureStimuli : MonoBehaviourStimuli
	{
		// Token: 0x06000DAB RID: 3499 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000DAB")]
		[Address(RVA = "0x2BA6010", Offset = "0x2BA4610", VA = "0x182BA6010")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000DAC")]
		[Address(RVA = "0x2BA6040", Offset = "0x2BA4640", VA = "0x182BA6040")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x00007CE0 File Offset: 0x00005EE0
		[Token(Token = "0x6000DAD")]
		[Address(RVA = "0x9E1E00", Offset = "0x9E0400", VA = "0x1809E1E00")]
		public static int GridType()
		{
			return 0;
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DAE")]
		[Address(RVA = "0x2B95780", Offset = "0x2B93D80", VA = "0x182B95780")]
		public PlayerStructureStimuli()
		{
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x00007CF8 File Offset: 0x00005EF8
		[Token(Token = "0x6000DAF")]
		[Address(RVA = "0x2BA60C0", Offset = "0x2BA46C0", VA = "0x182BA60C0", Slot = "18")]
		public override Vector3 GetLookAtPosition()
		{
			return default(Vector3);
		}
	}
}
