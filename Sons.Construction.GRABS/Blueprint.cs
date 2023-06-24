using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Sons.Construction.GRABS
{
	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	public class Blueprint
	{
		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000038")]
		public BlueprintMB Behaviour
		{
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00002564 File Offset: 0x00000764
		// (set) Token: 0x060000AA RID: 170 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000039")]
		public bool Edited
		{
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x642350", Offset = "0x640950", VA = "0x180642350")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x7AAFD0", Offset = "0x7A95D0", VA = "0x1807AAFD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000AB RID: 171 RVA: 0x0000257C File Offset: 0x0000077C
		// (set) Token: 0x060000AC RID: 172 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700003A")]
		public int Num
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x7814F0", Offset = "0x77FAF0", VA = "0x1807814F0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x781500", Offset = "0x77FB00", VA = "0x180781500")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00002594 File Offset: 0x00000794
		[Token(Token = "0x1700003B")]
		public int NextFaceNum
		{
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x2D8D0D0", Offset = "0x2D8B6D0", VA = "0x182D8D0D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000AE RID: 174 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x1700003C")]
		public List<BlueprintFace> Faces
		{
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x2D8D170", Offset = "0x2D8B770", VA = "0x182D8D170")]
		public void AddFace(BlueprintFace face)
		{
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x2D8D1E0", Offset = "0x2D8B7E0", VA = "0x182D8D1E0")]
		public void RemoveFace(BlueprintFace face)
		{
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x2D8D380", Offset = "0x2D8B980", VA = "0x182D8D380")]
		public Blueprint()
		{
		}

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x10")]
		private List<BlueprintFace> _faces;
	}
}
