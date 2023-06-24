using System;
using Endnight.Utilities;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Items.Core
{
	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	[Serializable]
	public abstract class ItemBase
	{
		// Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x30AE840", Offset = "0x30ACE40", VA = "0x1830AE840")]
		protected ItemBase(int id, string name)
		{
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00002208 File Offset: 0x00000408
		[Token(Token = "0x17000013")]
		public int Id
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
		public void SetId(int id)
		{
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00002220 File Offset: 0x00000420
		[Token(Token = "0x17000014")]
		public Types Type
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
			get
			{
				return (Types)0;
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x5FD590", Offset = "0x5FBB90", VA = "0x1805FD590")]
		public void SetType(Types type)
		{
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600003D RID: 61 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000015")]
		public string Name
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
		public void SetName(string name)
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002238 File Offset: 0x00000438
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x30AE8A0", Offset = "0x30ACEA0", VA = "0x1830AE8A0")]
		public bool MatchType(Types type)
		{
			return default(bool);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002250 File Offset: 0x00000450
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[HideInInspector]
		protected int _id;

		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public string _editorName;

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[EnumFlags]
		[Header("Base Item:")]
		protected Types _type;

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected string _name;
	}
}
