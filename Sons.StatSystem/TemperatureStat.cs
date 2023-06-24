using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.StatSystem
{
	// Token: 0x0200001C RID: 28
	[Token(Token = "0x200001C")]
	[Serializable]
	public class TemperatureStat : Stat
	{
		// Token: 0x060000B5 RID: 181 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x3146500", Offset = "0x3144B00", VA = "0x183146500", Slot = "6")]
		public override string GetToolTip()
		{
			return null;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x3146530", Offset = "0x3144B30", VA = "0x183146530", Slot = "7")]
		public override string GetId()
		{
			return null;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x3146560", Offset = "0x3144B60", VA = "0x183146560")]
		public TemperatureStat()
		{
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x3146580", Offset = "0x3144B80", VA = "0x183146580", Slot = "8")]
		public override void OnValidate()
		{
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000024A4 File Offset: 0x000006A4
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x3146620", Offset = "0x3144C20", VA = "0x183146620")]
		public bool IsFreezing()
		{
			return default(bool);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x3146630", Offset = "0x3144C30", VA = "0x183146630", Slot = "9")]
		public override void Update(Vector3 worldPosition, float deltaTime)
		{
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x620F20", Offset = "0x61F520", VA = "0x180620F20")]
		public void SetAmbientSourceMethod(Func<Vector3, bool, float> sourceMethod)
		{
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x3146760", Offset = "0x3144D60", VA = "0x183146760", Slot = "10")]
		public override string InspectorReadout()
		{
			return null;
		}

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x60")]
		private Func<Vector3, bool, float> _ambientSourceMethod;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _freezingTemperature;

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x6C")]
		public bool _interiorSpaceWarmth;
	}
}
