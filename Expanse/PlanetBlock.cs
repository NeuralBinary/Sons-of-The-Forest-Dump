using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Expanse
{
	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	[ExecuteInEditMode]
	[Serializable]
	public class PlanetBlock : MonoBehaviour
	{
		// Token: 0x06000210 RID: 528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000210")]
		[Address(RVA = "0xAB9550", Offset = "0xAB7B50", VA = "0x180AB9550")]
		private void OnEnable()
		{
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000211")]
		[Address(RVA = "0xAB9630", Offset = "0xAB7C30", VA = "0x180AB9630")]
		private void OnDisable()
		{
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000212")]
		[Address(RVA = "0xAB9680", Offset = "0xAB7C80", VA = "0x180AB9680")]
		public PlanetBlock()
		{
		}

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x20")]
		[Min(10f)]
		[Tooltip("The total thickness of the atmosphere, in world units.")]
		public float m_atmosphereThickness;

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x24")]
		[Min(10f)]
		[Tooltip("The radius of the planet, in world units.")]
		public float m_radius;

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("The planet origin, in world units, but specified as an offset from the position (0, -radius, 0), since that origin is much more convenient.")]
		public Vector3 m_originOffset;

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		[Tooltip("Distance to fade geometry to sky, as a function of the clip plane distance. Useful for flight sims with flat terrain to smoothly fade out to the curved planet.")]
		public float m_clipFade;

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("The ground albedo as a cubemap texture. The ground is modeled as a Lambertian (completely diffuse) reflector. If no texture is specified, the color of the ground will just be the ground tint.")]
		public Cubemap m_groundAlbedoTexture;

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("A color tint to the ground texture. Perfect grey, (128, 128, 128), specifies no tint. If there is no ground texture specified, this is just the color of the ground. If the tint is black, this can give a performance boost, since the ground will not be lit.")]
		public Color m_groundTint;

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("The ground emission as a cubemap texture. Useful for modeling things like city lights. Has no effect on the sky. See \"Light Pollution\" for a way of modeling an emissive ground's effect on the atmosphere.")]
		public Cubemap m_groundEmissionTexture;

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x58")]
		[Tooltip("An intensity multiplier on the ground emission texture.")]
		[Min(0f)]
		public float m_groundEmissionMultiplier;

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x5C")]
		[Tooltip("The rotation of the planet textures as euler angles. This won't do anything to light directions, star rotations, etc. It is purely for rotating the planet's albedo and emissive textures.")]
		public Vector3 m_rotation;
	}
}
