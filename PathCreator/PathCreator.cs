using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace PathCreation
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	public class PathCreator : MonoBehaviour
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600003E RID: 62 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x0600003F RID: 63 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000002")]
		public event Action pathUpdated
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x282D060", Offset = "0x282B660", VA = "0x18282D060")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x282D150", Offset = "0x282B750", VA = "0x18282D150")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000040 RID: 64 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x1700000E")]
		public VertexPath path
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x282D240", Offset = "0x282B840", VA = "0x18282D240")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000041 RID: 65 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000F")]
		public BezierPath bezierPath
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x282D3D0", Offset = "0x282B9D0", VA = "0x18282D3D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x282D410", Offset = "0x282BA10", VA = "0x18282D410")]
			set
			{
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x282D460", Offset = "0x282BA60", VA = "0x18282D460")]
		public void InitializeEditorData(bool in2DMode)
		{
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000044 RID: 68 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x17000010")]
		public PathCreatorData EditorData
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x282D840", Offset = "0x282BE40", VA = "0x18282D840")]
		public void TriggerPathUpdate()
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void CenterTransform()
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public PathCreator()
		{
		}

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[HideInInspector]
		private PathCreatorData editorData;

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[HideInInspector]
		private bool initialized;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x38")]
		private GlobalDisplaySettings globalEditorDisplaySettings;
	}
}
