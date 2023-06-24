using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x02000038 RID: 56
	[Token(Token = "0x2000038")]
	[Serializable]
	public class MeleeWeapon
	{
		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600034B RID: 843 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x1700003A")]
		public string Id
		{
			[Token(Token = "0x600034B")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600034C RID: 844 RVA: 0x000037F8 File Offset: 0x000019F8
		[Token(Token = "0x600034C")]
		[Address(RVA = "0x7814F0", Offset = "0x77FAF0", VA = "0x1807814F0")]
		public int AnimStateHash()
		{
			return 0;
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00003810 File Offset: 0x00001A10
		[Token(Token = "0x600034D")]
		[Address(RVA = "0x642350", Offset = "0x640950", VA = "0x180642350")]
		public bool IsEnabled()
		{
			return default(bool);
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034E")]
		[Address(RVA = "0x2AFD170", Offset = "0x2AFB770", VA = "0x182AFD170")]
		public void SetEnabled(bool value, int stateHash = 0)
		{
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034F")]
		[Address(RVA = "0x2AFD2A0", Offset = "0x2AFB8A0", VA = "0x182AFD2A0")]
		public void AddDebugCollider()
		{
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000350")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public MeleeWeapon()
		{
		}

		// Token: 0x040002CF RID: 719
		[Token(Token = "0x40002CF")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _id;

		// Token: 0x040002D0 RID: 720
		[Token(Token = "0x40002D0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _gameObject;

		// Token: 0x040002D1 RID: 721
		[Token(Token = "0x40002D1")]
		[FieldOffset(Offset = "0x20")]
		private bool _enabled;

		// Token: 0x040002D2 RID: 722
		[Token(Token = "0x40002D2")]
		[FieldOffset(Offset = "0x24")]
		private int _animStateHash;
	}
}
