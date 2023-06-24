using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x020001E9 RID: 489
	[Token(Token = "0x20001E9")]
	[AddComponentMenu("Sons/Stimuli/Surface Walk Stimuli")]
	public class SurfaceWalkStimuli : MonoBehaviourStimuli
	{
		// Token: 0x06000E54 RID: 3668 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000E54")]
		[Address(RVA = "0x2BAC880", Offset = "0x2BAAE80", VA = "0x182BAC880")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000E55 RID: 3669 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000E55")]
		[Address(RVA = "0x2BAC8B0", Offset = "0x2BAAEB0", VA = "0x182BAC8B0")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x00008160 File Offset: 0x00006360
		[Token(Token = "0x6000E56")]
		[Address(RVA = "0x67D850", Offset = "0x67BE50", VA = "0x18067D850")]
		public static int GridType()
		{
			return 0;
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000E57")]
		[Address(RVA = "0x751010", Offset = "0x74F610", VA = "0x180751010")]
		public SurfaceMoverPath GetSurfacePath()
		{
			return null;
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000E58")]
		[Address(RVA = "0xA03D90", Offset = "0xA02390", VA = "0x180A03D90")]
		public SurfaceMoverPoint GetStartPoint()
		{
			return null;
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E59")]
		[Address(RVA = "0x1243280", Offset = "0x1241880", VA = "0x181243280")]
		public SurfaceWalkStimuli()
		{
		}

		// Token: 0x040008F9 RID: 2297
		[Token(Token = "0x40008F9")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private SurfaceMoverPath _surfacePath;

		// Token: 0x040008FA RID: 2298
		[Token(Token = "0x40008FA")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private SurfaceMoverPoint _startSurfacePoint;
	}
}
