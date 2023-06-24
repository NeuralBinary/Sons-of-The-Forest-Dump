using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x0200030F RID: 783
	[Token(Token = "0x200030F")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Cinematic/Anti-aliasing")]
	[ImageEffectAllowedInSceneView]
	public class AntiAliasing : MonoBehaviour
	{
		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x0600148C RID: 5260 RVA: 0x00006BD0 File Offset: 0x00004DD0
		// (set) Token: 0x0600148D RID: 5261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002D4")]
		public int method
		{
			[Token(Token = "0x600148C")]
			[Address(RVA = "0x65D0F0", Offset = "0x65B6F0", VA = "0x18065D0F0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600148D")]
			[Address(RVA = "0x320E2E0", Offset = "0x320C8E0", VA = "0x18320E2E0")]
			set
			{
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x0600148E RID: 5262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D5")]
		public IAntiAliasing current
		{
			[Token(Token = "0x600148E")]
			[Address(RVA = "0x320E2F0", Offset = "0x320C8F0", VA = "0x18320E2F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x0600148F RID: 5263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D6")]
		public Camera cameraComponent
		{
			[Token(Token = "0x600148F")]
			[Address(RVA = "0x320E300", Offset = "0x320C900", VA = "0x18320E300")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001490")]
		[Address(RVA = "0x320E440", Offset = "0x320CA40", VA = "0x18320E440")]
		private void Awake()
		{
		}

		// Token: 0x06001491 RID: 5265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001491")]
		[Address(RVA = "0x320E540", Offset = "0x320CB40", VA = "0x18320E540")]
		private void OnEnable()
		{
		}

		// Token: 0x06001492 RID: 5266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001492")]
		[Address(RVA = "0x320E640", Offset = "0x320CC40", VA = "0x18320E640")]
		private void OnDisable()
		{
		}

		// Token: 0x06001493 RID: 5267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001493")]
		[Address(RVA = "0x320E750", Offset = "0x320CD50", VA = "0x18320E750")]
		private void OnPreCull()
		{
		}

		// Token: 0x06001494 RID: 5268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001494")]
		[Address(RVA = "0x320E7C0", Offset = "0x320CDC0", VA = "0x18320E7C0")]
		private void OnPostRender()
		{
		}

		// Token: 0x06001495 RID: 5269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001495")]
		[Address(RVA = "0x320E830", Offset = "0x320CE30", VA = "0x18320E830")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001496")]
		[Address(RVA = "0x320E930", Offset = "0x320CF30", VA = "0x18320E930")]
		public AntiAliasing()
		{
		}

		// Token: 0x04001455 RID: 5205
		[Token(Token = "0x4001455")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SMAA m_SMAA;

		// Token: 0x04001456 RID: 5206
		[Token(Token = "0x4001456")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private FXAA m_FXAA;

		// Token: 0x04001457 RID: 5207
		[Token(Token = "0x4001457")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[HideInInspector]
		private int m_Method;

		// Token: 0x04001458 RID: 5208
		[Token(Token = "0x4001458")]
		[FieldOffset(Offset = "0x38")]
		private Camera m_Camera;

		// Token: 0x02000310 RID: 784
		[Token(Token = "0x2000310")]
		public enum Method
		{
			// Token: 0x0400145A RID: 5210
			[Token(Token = "0x400145A")]
			Smaa,
			// Token: 0x0400145B RID: 5211
			[Token(Token = "0x400145B")]
			Fxaa
		}
	}
}
