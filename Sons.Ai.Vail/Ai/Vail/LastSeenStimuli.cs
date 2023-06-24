using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x020000A9 RID: 169
	[Token(Token = "0x20000A9")]
	public class LastSeenStimuli : IStimuli
	{
		// Token: 0x0600068A RID: 1674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600068A")]
		[Address(RVA = "0x2B3EFC0", Offset = "0x2B3D5C0", VA = "0x182B3EFC0")]
		public LastSeenStimuli(MonoBehaviourStimuli stimuli)
		{
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600068B")]
		[Address(RVA = "0x2B3EFD0", Offset = "0x2B3D5D0", VA = "0x182B3EFD0")]
		public void InitFromStimuli(MonoBehaviourStimuli stimuli)
		{
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x00005058 File Offset: 0x00003258
		[Token(Token = "0x600068C")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "4")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x00005070 File Offset: 0x00003270
		[Token(Token = "0x600068D")]
		[Address(RVA = "0x2B3F0B0", Offset = "0x2B3D6B0", VA = "0x182B3F0B0")]
		public float TimeSinceSeen()
		{
			return 0f;
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x00005088 File Offset: 0x00003288
		[Token(Token = "0x600068E")]
		[Address(RVA = "0x1766460", Offset = "0x1764A60", VA = "0x181766460")]
		public Vector3 Position()
		{
			return default(Vector3);
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x000050A0 File Offset: 0x000032A0
		[Token(Token = "0x600068F")]
		[Address(RVA = "0x1766460", Offset = "0x1764A60", VA = "0x181766460")]
		public Vector3 GetLookAtPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x000050B8 File Offset: 0x000032B8
		[Token(Token = "0x6000690")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "7")]
		public virtual bool Validate(VailActor vailActor)
		{
			return default(bool);
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000691")]
		[Address(RVA = "0x2B3F110", Offset = "0x2B3D710", VA = "0x182B3F110", Slot = "6")]
		public string GetLog()
		{
			return null;
		}

		// Token: 0x0400053C RID: 1340
		[Token(Token = "0x400053C")]
		[FieldOffset(Offset = "0x10")]
		private Vector3 _position;

		// Token: 0x0400053D RID: 1341
		[Token(Token = "0x400053D")]
		[FieldOffset(Offset = "0x1C")]
		private float _time;

		// Token: 0x0400053E RID: 1342
		[Token(Token = "0x400053E")]
		[FieldOffset(Offset = "0x20")]
		private Type _stimuliType;
	}
}
