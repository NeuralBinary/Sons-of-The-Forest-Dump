using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace AdvancedTerrainGrass
{
	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	[RequireComponent(typeof(Camera))]
	public class AtgHiZBuffer : MonoBehaviour
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000001")]
		public Shader shader
		{
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x5AC340", Offset = "0x5AA940", VA = "0x1805AC340")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000002")]
		public Material material
		{
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x5AC460", Offset = "0x5AAA60", VA = "0x1805AC460")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000003")]
		public Camera camera
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x5AC680", Offset = "0x5AAC80", VA = "0x1805AC680")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000004")]
		public RenderTexture texture
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600002D RID: 45 RVA: 0x000020CC File Offset: 0x000002CC
		[Token(Token = "0x17000005")]
		public int lodCount
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x5AC7D0", Offset = "0x5AADD0", VA = "0x1805AC7D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x5AC8A0", Offset = "0x5AAEA0", VA = "0x1805AC8A0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x5AC960", Offset = "0x5AAF60", VA = "0x1805AC960")]
		private void OnDisable()
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x5ACC00", Offset = "0x5AB200", VA = "0x1805ACC00")]
		private void OnPreRender()
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x5AD950", Offset = "0x5ABF50", VA = "0x1805AD950")]
		public AtgHiZBuffer()
		{
		}

		// Token: 0x0400010B RID: 267
		[Token(Token = "0x400010B")]
		private const int MAXIMUM_BUFFER_SIZE = 2048;

		// Token: 0x0400010C RID: 268
		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x20")]
		public bool HiZavailable;

		// Token: 0x0400010D RID: 269
		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x28")]
		private Shader m_Shader;

		// Token: 0x0400010E RID: 270
		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x30")]
		private Material m_Material;

		// Token: 0x0400010F RID: 271
		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x38")]
		private Camera m_Camera;

		// Token: 0x04000110 RID: 272
		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x40")]
		private RenderTexture m_HiZ;

		// Token: 0x04000111 RID: 273
		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x48")]
		private int m_LODCount;

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x50")]
		private CommandBuffer m_CommandBuffer;

		// Token: 0x04000113 RID: 275
		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x58")]
		private CameraEvent m_CameraEvent;

		// Token: 0x04000114 RID: 276
		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x60")]
		private int[] m_Temporaries;

		// Token: 0x02000010 RID: 16
		[Token(Token = "0x2000010")]
		private enum Pass
		{
			// Token: 0x04000116 RID: 278
			[Token(Token = "0x4000116")]
			Blit,
			// Token: 0x04000117 RID: 279
			[Token(Token = "0x4000117")]
			Reduce
		}
	}
}
