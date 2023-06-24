using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x02000169 RID: 361
	[Token(Token = "0x2000169")]
	[AddComponentMenu("Sons/Stimuli/CeilingWalkStimuli")]
	public class CeilingWalkStimuli : MonoBehaviourStimuli
	{
		// Token: 0x06000BBE RID: 3006 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000BBE")]
		[Address(RVA = "0x2B95930", Offset = "0x2B93F30", VA = "0x182B95930")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000BBF")]
		[Address(RVA = "0x2B95960", Offset = "0x2B93F60", VA = "0x182B95960")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000BC0")]
		[Address(RVA = "0x751010", Offset = "0x74F610", VA = "0x180751010")]
		public CeilingWalkArea GetCeilingWalkArea()
		{
			return null;
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x00007230 File Offset: 0x00005430
		[Token(Token = "0x6000BC1")]
		[Address(RVA = "0x2B959E0", Offset = "0x2B93FE0", VA = "0x182B959E0", Slot = "19")]
		public override bool GetSnapToTarget(VailActor vailActor, bool allowReserveLocation, out Vector3 position, out Quaternion rotation)
		{
			return default(bool);
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x00007248 File Offset: 0x00005448
		[Token(Token = "0x6000BC2")]
		[Address(RVA = "0x2B95B80", Offset = "0x2B94180", VA = "0x182B95B80", Slot = "12")]
		public override bool Validate(VailActor actor)
		{
			return default(bool);
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BC3")]
		[Address(RVA = "0x2B95D00", Offset = "0x2B94300", VA = "0x182B95D00")]
		public CeilingWalkStimuli()
		{
		}

		// Token: 0x04000842 RID: 2114
		[Token(Token = "0x4000842")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private CeilingWalkArea _ceilingWalkArea;

		// Token: 0x04000843 RID: 2115
		[Token(Token = "0x4000843")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private float _minEdgeDistance;
	}
}
