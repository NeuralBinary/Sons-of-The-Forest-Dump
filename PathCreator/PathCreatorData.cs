using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace PathCreation
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	[Serializable]
	public class PathCreatorData
	{
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000048 RID: 72 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x06000049 RID: 73 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000003")]
		public event Action bezierOrVertexPathModified
		{
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x282D860", Offset = "0x282BE60", VA = "0x18282D860")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x282D950", Offset = "0x282BF50", VA = "0x18282D950")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600004A RID: 74 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x0600004B RID: 75 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000004")]
		public event Action bezierCreated
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x282DA40", Offset = "0x282C040", VA = "0x18282DA40")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x282DB30", Offset = "0x282C130", VA = "0x18282DB30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x282DC20", Offset = "0x282C220", VA = "0x18282DC20")]
		public void Initialize(bool defaultIs2D)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x282DD10", Offset = "0x282C310", VA = "0x18282DD10")]
		public void ResetBezierPath(bool defaultIs2D = false)
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x282DD20", Offset = "0x282C320", VA = "0x18282DD20")]
		private void CreateBezier(bool defaultIs2D = false)
		{
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600004F RID: 79 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000011")]
		public BezierPath bezierPath
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x282DEB0", Offset = "0x282C4B0", VA = "0x18282DEB0")]
			set
			{
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x282E010", Offset = "0x282C610", VA = "0x18282E010")]
		public VertexPath GetVertexPath(Transform transform)
		{
			return null;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x282E130", Offset = "0x282C730", VA = "0x18282E130")]
		public void PathTransformed()
		{
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x282CC50", Offset = "0x282B250", VA = "0x18282CC50")]
		public void VertexPathSettingsChanged()
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x282CC50", Offset = "0x282B250", VA = "0x18282CC50")]
		public void PathModifiedByUndo()
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x282CC50", Offset = "0x282B250", VA = "0x18282CC50")]
		private void BezierPathEdited()
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x282E150", Offset = "0x282C750", VA = "0x18282E150")]
		public PathCreatorData()
		{
		}

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BezierPath _bezierPath;

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x28")]
		private VertexPath _vertexPath;

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool vertexPathUpToDate;

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x34")]
		public float vertexPathMaxAngleError;

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x38")]
		public float vertexPathMinVertexSpacing;

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x3C")]
		public bool showTransformTool;

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x3D")]
		public bool showPathBounds;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x3E")]
		public bool showPerSegmentBounds;

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x3F")]
		public bool displayAnchorPoints;

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x40")]
		public bool displayControlPoints;

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x44")]
		public float bezierHandleScale;

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x48")]
		public bool globalDisplaySettingsFoldout;

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x49")]
		public bool keepConstantHandleSize;

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x4A")]
		public bool showNormalsInVertexMode;

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x4B")]
		public bool showBezierPathInVertexMode;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x4C")]
		public bool showDisplayOptions;

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x4D")]
		public bool showPathOptions;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x4E")]
		public bool showVertexPathDisplayOptions;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x4F")]
		public bool showVertexPathOptions;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x50")]
		public bool showNormals;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x51")]
		public bool showNormalsHelpInfo;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x54")]
		public int tabIndex;
	}
}
