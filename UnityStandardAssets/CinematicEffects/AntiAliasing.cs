using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x0200031D RID: 797
	[Token(Token = "0x200031D")]
	[ImageEffectAllowedInSceneView]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Cinematic/Anti-aliasing")]
	public class AntiAliasing : MonoBehaviour
	{
		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06001461 RID: 5217 RVA: 0x00006990 File Offset: 0x00004B90
		// (set) Token: 0x06001462 RID: 5218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002CC")]
		public int method
		{
			[Token(Token = "0x6001461")]
			[Address(RVA = "0x5CEF60", Offset = "0x5CDF60", VA = "0x1805CEF60")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6001462")]
			[Address(RVA = "0x2C5E540", Offset = "0x2C5D540", VA = "0x182C5E540")]
			set
			{
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06001463 RID: 5219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002CD")]
		public IAntiAliasing current
		{
			[Token(Token = "0x6001463")]
			[Address(RVA = "0x2C5E530", Offset = "0x2C5D530", VA = "0x182C5E530")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06001464 RID: 5220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002CE")]
		public Camera cameraComponent
		{
			[Token(Token = "0x6001464")]
			[Address(RVA = "0x2C5E490", Offset = "0x2C5D490", VA = "0x182C5E490")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001465")]
		[Address(RVA = "0x2C5DFE0", Offset = "0x2C5CFE0", VA = "0x182C5DFE0")]
		private void Awake()
		{
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001466")]
		[Address(RVA = "0x2C5E110", Offset = "0x2C5D110", VA = "0x182C5E110")]
		private void OnEnable()
		{
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001467")]
		[Address(RVA = "0x2C5E060", Offset = "0x2C5D060", VA = "0x182C5E060")]
		private void OnDisable()
		{
		}

		// Token: 0x06001468 RID: 5224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001468")]
		[Address(RVA = "0x2C5E1F0", Offset = "0x2C5D1F0", VA = "0x182C5E1F0")]
		private void OnPreCull()
		{
		}

		// Token: 0x06001469 RID: 5225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001469")]
		[Address(RVA = "0x2C5E180", Offset = "0x2C5D180", VA = "0x182C5E180")]
		private void OnPostRender()
		{
		}

		// Token: 0x0600146A RID: 5226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600146A")]
		[Address(RVA = "0x2C5E260", Offset = "0x2C5D260", VA = "0x182C5E260")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0600146B RID: 5227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600146B")]
		[Address(RVA = "0x2C5E360", Offset = "0x2C5D360", VA = "0x182C5E360")]
		public AntiAliasing()
		{
		}

		// Token: 0x04001437 RID: 5175
		[Token(Token = "0x4001437")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SMAA m_SMAA;

		// Token: 0x04001438 RID: 5176
		[Token(Token = "0x4001438")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private FXAA m_FXAA;

		// Token: 0x04001439 RID: 5177
		[Token(Token = "0x4001439")]
		[FieldOffset(Offset = "0x30")]
		[HideInInspector]
		[SerializeField]
		private int m_Method;

		// Token: 0x0400143A RID: 5178
		[Token(Token = "0x400143A")]
		[FieldOffset(Offset = "0x38")]
		private Camera m_Camera;

		// Token: 0x0200031E RID: 798
		[Token(Token = "0x200031E")]
		public enum Method
		{
			// Token: 0x0400143C RID: 5180
			[Token(Token = "0x400143C")]
			Smaa,
			// Token: 0x0400143D RID: 5181
			[Token(Token = "0x400143D")]
			Fxaa
		}
	}
}
