using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x020001EF RID: 495
	[Token(Token = "0x20001EF")]
	[AddComponentMenu("Sons/Stimuli/Wall Stimuli")]
	public class WallStimuli : StructureStimuli
	{
		// Token: 0x06000E74 RID: 3700 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000E74")]
		[Address(RVA = "0x2BADC40", Offset = "0x2BAC240", VA = "0x182BADC40")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000E75")]
		[Address(RVA = "0x2BADC70", Offset = "0x2BAC270", VA = "0x182BADC70")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x00008238 File Offset: 0x00006438
		[Token(Token = "0x6000E76")]
		[Address(RVA = "0x2BADCF0", Offset = "0x2BAC2F0", VA = "0x182BADCF0", Slot = "21")]
		public override bool TryRequestLocation(VailActor requester, out Transform outTransform)
		{
			return default(bool);
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x00008250 File Offset: 0x00006450
		[Token(Token = "0x6000E77")]
		[Address(RVA = "0x2BADDE0", Offset = "0x2BAC3E0", VA = "0x182BADDE0", Slot = "19")]
		public override bool GetSnapToTarget(VailActor vailActor, bool allowReserveLoc, out Vector3 position, out Quaternion rotation)
		{
			return default(bool);
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x00008268 File Offset: 0x00006468
		[Token(Token = "0x6000E78")]
		[Address(RVA = "0x2BAE020", Offset = "0x2BAC620", VA = "0x182BAE020", Slot = "26")]
		protected override bool CheckTopFree()
		{
			return default(bool);
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x00008280 File Offset: 0x00006480
		[Token(Token = "0x6000E79")]
		[Address(RVA = "0x2BAE1B0", Offset = "0x2BAC7B0", VA = "0x182BAE1B0", Slot = "27")]
		protected override bool CheckLeftFree()
		{
			return default(bool);
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x00008298 File Offset: 0x00006498
		[Token(Token = "0x6000E7A")]
		[Address(RVA = "0x2BAE460", Offset = "0x2BACA60", VA = "0x182BAE460", Slot = "28")]
		protected override bool CheckRightFree()
		{
			return default(bool);
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E7B")]
		[Address(RVA = "0x2BAE710", Offset = "0x2BACD10", VA = "0x182BAE710")]
		public WallStimuli()
		{
		}

		// Token: 0x040008FC RID: 2300
		[Token(Token = "0x40008FC")]
		private const float WallHeight = 1.8f;
	}
}
