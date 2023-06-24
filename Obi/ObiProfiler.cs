using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x020001CB RID: 459
	[Token(Token = "0x20001CB")]
	[DisallowMultipleComponent]
	public class ObiProfiler : MonoBehaviour
	{
		// Token: 0x060008E4 RID: 2276 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x27FD2F0", Offset = "0x27FB8F0", VA = "0x1827FD2F0")]
		private void Awake()
		{
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x27FD540", Offset = "0x27FBB40", VA = "0x1827FD540")]
		public void OnDestroy()
		{
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x27FD5D0", Offset = "0x27FBBD0", VA = "0x1827FD5D0")]
		private void OnEnable()
		{
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x27FD6D0", Offset = "0x27FBCD0", VA = "0x1827FD6D0")]
		private void OnDisable()
		{
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x27FD7B0", Offset = "0x27FBDB0", VA = "0x1827FD7B0")]
		public static void EnableProfiler()
		{
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x27FD910", Offset = "0x27FBF10", VA = "0x1827FD910")]
		public static void DisableProfiler()
		{
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x27FDA10", Offset = "0x27FC010", VA = "0x1827FDA10")]
		public static void BeginSample(string name, byte type)
		{
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x27FDB90", Offset = "0x27FC190", VA = "0x1827FDB90")]
		public static void EndSample()
		{
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x27FDCC0", Offset = "0x27FC2C0", VA = "0x1827FDCC0")]
		private void UpdateProfilerInfo()
		{
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x27FDFA0", Offset = "0x27FC5A0", VA = "0x1827FDFA0")]
		public void OnGUI()
		{
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x27FEDD0", Offset = "0x27FD3D0", VA = "0x1827FEDD0")]
		public ObiProfiler()
		{
		}

		// Token: 0x04000776 RID: 1910
		[Token(Token = "0x4000776")]
		[FieldOffset(Offset = "0x20")]
		[Header("Appearance")]
		public GUISkin skin;

		// Token: 0x04000777 RID: 1911
		[Token(Token = "0x4000777")]
		[FieldOffset(Offset = "0x28")]
		public Color threadColor;

		// Token: 0x04000778 RID: 1912
		[Token(Token = "0x4000778")]
		[FieldOffset(Offset = "0x38")]
		public Color taskColor;

		// Token: 0x04000779 RID: 1913
		[Token(Token = "0x4000779")]
		[FieldOffset(Offset = "0x48")]
		public Color parallelTaskColor;

		// Token: 0x0400077A RID: 1914
		[Token(Token = "0x400077A")]
		[FieldOffset(Offset = "0x58")]
		public Color renderTaskColor;

		// Token: 0x0400077B RID: 1915
		[Token(Token = "0x400077B")]
		[FieldOffset(Offset = "0x68")]
		public Color defaultTaskColor;

		// Token: 0x0400077C RID: 1916
		[Token(Token = "0x400077C")]
		[FieldOffset(Offset = "0x78")]
		[Header("Visualization")]
		public bool showPercentages;

		// Token: 0x0400077D RID: 1917
		[Token(Token = "0x400077D")]
		[FieldOffset(Offset = "0x7C")]
		public int profileThrottle;

		// Token: 0x0400077E RID: 1918
		[Token(Token = "0x400077E")]
		[FieldOffset(Offset = "0x80")]
		private Oni.ProfileInfo[] info;

		// Token: 0x0400077F RID: 1919
		[Token(Token = "0x400077F")]
		[FieldOffset(Offset = "0x88")]
		private double frameStart;

		// Token: 0x04000780 RID: 1920
		[Token(Token = "0x4000780")]
		[FieldOffset(Offset = "0x90")]
		private double frameEnd;

		// Token: 0x04000781 RID: 1921
		[Token(Token = "0x4000781")]
		[FieldOffset(Offset = "0x98")]
		private int frameCounter;

		// Token: 0x04000782 RID: 1922
		[Token(Token = "0x4000782")]
		[FieldOffset(Offset = "0x9C")]
		private int yPos;

		// Token: 0x04000783 RID: 1923
		[Token(Token = "0x4000783")]
		[FieldOffset(Offset = "0xA0")]
		private bool profiling;

		// Token: 0x04000784 RID: 1924
		[Token(Token = "0x4000784")]
		[FieldOffset(Offset = "0xA4")]
		private float zoom;

		// Token: 0x04000785 RID: 1925
		[Token(Token = "0x4000785")]
		[FieldOffset(Offset = "0xA8")]
		private Vector2 scrollPosition;

		// Token: 0x04000786 RID: 1926
		[Token(Token = "0x4000786")]
		[FieldOffset(Offset = "0x0")]
		private static ObiProfiler _instance;
	}
}
