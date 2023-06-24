using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Examples
{
	// Token: 0x0200017E RID: 382
	[Token(Token = "0x200017E")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_examples_1_1_path_types_demo.php")]
	public class PathTypesDemo : MonoBehaviour
	{
		// Token: 0x06000BC4 RID: 3012 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BC4")]
		[Address(RVA = "0x651540", Offset = "0x64FB40", VA = "0x180651540")]
		private void Update()
		{
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BC5")]
		[Address(RVA = "0x651A00", Offset = "0x650000", VA = "0x180651A00")]
		public void OnGUI()
		{
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BC6")]
		[Address(RVA = "0x6520A0", Offset = "0x6506A0", VA = "0x1806520A0")]
		public void OnPathComplete(Path p)
		{
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BC7")]
		[Address(RVA = "0x6523F0", Offset = "0x6509F0", VA = "0x1806523F0")]
		private void ClearPrevious()
		{
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BC8")]
		[Address(RVA = "0x652580", Offset = "0x650B80", VA = "0x180652580")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BC9")]
		[Address(RVA = "0x6525F0", Offset = "0x650BF0", VA = "0x1806525F0")]
		private void DemoPath()
		{
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BCA")]
		[Address(RVA = "0x652F70", Offset = "0x651570", VA = "0x180652F70")]
		private IEnumerator DemoMultiTargetPath()
		{
			return null;
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BCB")]
		[Address(RVA = "0x653000", Offset = "0x651600", VA = "0x180653000")]
		public IEnumerator DemoConstantPath()
		{
			return null;
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BCC")]
		[Address(RVA = "0x653090", Offset = "0x651690", VA = "0x180653090")]
		public PathTypesDemo()
		{
		}

		// Token: 0x0400088B RID: 2187
		[Token(Token = "0x400088B")]
		[FieldOffset(Offset = "0x20")]
		public PathTypesDemo.DemoMode activeDemo;

		// Token: 0x0400088C RID: 2188
		[Token(Token = "0x400088C")]
		[FieldOffset(Offset = "0x28")]
		public Transform start;

		// Token: 0x0400088D RID: 2189
		[Token(Token = "0x400088D")]
		[FieldOffset(Offset = "0x30")]
		public Transform end;

		// Token: 0x0400088E RID: 2190
		[Token(Token = "0x400088E")]
		[FieldOffset(Offset = "0x38")]
		public Vector3 pathOffset;

		// Token: 0x0400088F RID: 2191
		[Token(Token = "0x400088F")]
		[FieldOffset(Offset = "0x48")]
		public Material lineMat;

		// Token: 0x04000890 RID: 2192
		[Token(Token = "0x4000890")]
		[FieldOffset(Offset = "0x50")]
		public Material squareMat;

		// Token: 0x04000891 RID: 2193
		[Token(Token = "0x4000891")]
		[FieldOffset(Offset = "0x58")]
		public float lineWidth;

		// Token: 0x04000892 RID: 2194
		[Token(Token = "0x4000892")]
		[FieldOffset(Offset = "0x5C")]
		public int searchLength;

		// Token: 0x04000893 RID: 2195
		[Token(Token = "0x4000893")]
		[FieldOffset(Offset = "0x60")]
		public int spread;

		// Token: 0x04000894 RID: 2196
		[Token(Token = "0x4000894")]
		[FieldOffset(Offset = "0x64")]
		public float aimStrength;

		// Token: 0x04000895 RID: 2197
		[Token(Token = "0x4000895")]
		[FieldOffset(Offset = "0x68")]
		private Path lastPath;

		// Token: 0x04000896 RID: 2198
		[Token(Token = "0x4000896")]
		[FieldOffset(Offset = "0x70")]
		private FloodPath lastFloodPath;

		// Token: 0x04000897 RID: 2199
		[Token(Token = "0x4000897")]
		[FieldOffset(Offset = "0x78")]
		private List<GameObject> lastRender;

		// Token: 0x04000898 RID: 2200
		[Token(Token = "0x4000898")]
		[FieldOffset(Offset = "0x80")]
		private List<Vector3> multipoints;

		// Token: 0x0200017F RID: 383
		[Token(Token = "0x200017F")]
		public enum DemoMode
		{
			// Token: 0x0400089A RID: 2202
			[Token(Token = "0x400089A")]
			ABPath,
			// Token: 0x0400089B RID: 2203
			[Token(Token = "0x400089B")]
			MultiTargetPath,
			// Token: 0x0400089C RID: 2204
			[Token(Token = "0x400089C")]
			RandomPath,
			// Token: 0x0400089D RID: 2205
			[Token(Token = "0x400089D")]
			FleePath,
			// Token: 0x0400089E RID: 2206
			[Token(Token = "0x400089E")]
			ConstantPath,
			// Token: 0x0400089F RID: 2207
			[Token(Token = "0x400089F")]
			FloodPath,
			// Token: 0x040008A0 RID: 2208
			[Token(Token = "0x40008A0")]
			FloodPathTracer
		}
	}
}
