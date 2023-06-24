using System;
using Il2CppDummyDll;
using Sons.Atmosphere;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x0200018F RID: 399
	[Token(Token = "0x200018F")]
	public class WaterStimuli : ConsumableStimuli, IFreezeWaterReceiver
	{
		// Token: 0x06000C6D RID: 3181 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000C6D")]
		[Address(RVA = "0x2B9BE20", Offset = "0x2B9A420", VA = "0x182B9BE20")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000C6E")]
		[Address(RVA = "0x2B9BE50", Offset = "0x2B9A450", VA = "0x182B9BE50")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x000074B8 File Offset: 0x000056B8
		[Token(Token = "0x6000C6F")]
		[Address(RVA = "0x6A2B30", Offset = "0x6A1130", VA = "0x1806A2B30")]
		public static int GridType()
		{
			return 0;
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C70")]
		[Address(RVA = "0x2B9B220", Offset = "0x2B99820", VA = "0x182B9B220")]
		private WaterStimuli()
		{
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C71")]
		[Address(RVA = "0x2962930", Offset = "0x2960F30", VA = "0x182962930", Slot = "33")]
		private void Freeze(bool value)
		{
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x000074D0 File Offset: 0x000056D0
		[Token(Token = "0x6000C72")]
		[Address(RVA = "0x2B9BED0", Offset = "0x2B9A4D0", VA = "0x182B9BED0", Slot = "11")]
		public override bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C73")]
		[Address(RVA = "0x2B9BFA0", Offset = "0x2B9A5A0", VA = "0x182B9BFA0")]
		private void SnapToTerrain()
		{
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x000074E8 File Offset: 0x000056E8
		[Token(Token = "0x6000C74")]
		[Address(RVA = "0x2B9C030", Offset = "0x2B9A630", VA = "0x182B9C030", Slot = "19")]
		public override bool GetSnapToTarget(VailActor vailActor, bool allowReserveLoc, out Vector3 position, out Quaternion rotation)
		{
			return default(bool);
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C75")]
		[Address(RVA = "0x2B9C150", Offset = "0x2B9A750", VA = "0x182B9C150", Slot = "15")]
		public override void OnInteractAnimEvent(VailActor actor, string param)
		{
		}

		// Token: 0x04000864 RID: 2148
		[Token(Token = "0x4000864")]
		[FieldOffset(Offset = "0xE0")]
		private bool _isFrozen;
	}
}
