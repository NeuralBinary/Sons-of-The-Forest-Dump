using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay.Achievements
{
	// Token: 0x02000885 RID: 2181
	[Token(Token = "0x2000885")]
	public abstract class Achievement : MonoBehaviour
	{
		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x06003E51 RID: 15953 RVA: 0x000130E0 File Offset: 0x000112E0
		[Token(Token = "0x17000823")]
		public int Id
		{
			[Token(Token = "0x6003E51")]
			[Address(RVA = "0x65D0F0", Offset = "0x65B6F0", VA = "0x18065D0F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x06003E52 RID: 15954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000824")]
		public string ApiName
		{
			[Token(Token = "0x6003E52")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x06003E53 RID: 15955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000825")]
		public string ApiStatName
		{
			[Token(Token = "0x6003E53")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003E54 RID: 15956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E54")]
		[Address(RVA = "0x35D09B0", Offset = "0x35CEFB0", VA = "0x1835D09B0")]
		public void Reset()
		{
		}

		// Token: 0x06003E55 RID: 15957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E55")]
		[Address(RVA = "0x35D09C0", Offset = "0x35CEFC0", VA = "0x1835D09C0")]
		private void OnValidate()
		{
		}

		// Token: 0x06003E56 RID: 15958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E56")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		public virtual void Initialize()
		{
		}

		// Token: 0x06003E57 RID: 15959 RVA: 0x000130F8 File Offset: 0x000112F8
		[Token(Token = "0x6003E57")]
		[Address(RVA = "0x35D0A00", Offset = "0x35CF000", VA = "0x1835D0A00")]
		public bool IsUnlocked()
		{
			return default(bool);
		}

		// Token: 0x06003E58 RID: 15960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E58")]
		[Address(RVA = "0x35D0A30", Offset = "0x35CF030", VA = "0x1835D0A30")]
		public void Unlock()
		{
		}

		// Token: 0x06003E59 RID: 15961
		[Token(Token = "0x6003E59")]
		protected abstract void TickStat(string statName);

		// Token: 0x06003E5A RID: 15962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E5A")]
		[Address(RVA = "0x35D0A40", Offset = "0x35CF040", VA = "0x1835D0A40", Slot = "6")]
		public virtual void TickAchievement()
		{
		}

		// Token: 0x06003E5B RID: 15963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E5B")]
		[Address(RVA = "0x35D0A60", Offset = "0x35CF060", VA = "0x1835D0A60")]
		protected void MarkForCleanup()
		{
		}

		// Token: 0x06003E5C RID: 15964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E5C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "7")]
		protected virtual void Cleanup()
		{
		}

		// Token: 0x06003E5D RID: 15965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E5D")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		protected Achievement()
		{
		}

		// Token: 0x04003468 RID: 13416
		[Token(Token = "0x4003468")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected string _apiName;

		// Token: 0x04003469 RID: 13417
		[Token(Token = "0x4003469")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected string _apiStatName;

		// Token: 0x0400346A RID: 13418
		[Token(Token = "0x400346A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected int _id;

		// Token: 0x0400346B RID: 13419
		[Token(Token = "0x400346B")]
		[FieldOffset(Offset = "0x34")]
		private bool _queuedForCleanup;
	}
}
