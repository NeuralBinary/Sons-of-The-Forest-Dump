using System;
using System.Collections;
using System.Collections.Generic;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Gameplay;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x02000040 RID: 64
	[Token(Token = "0x2000040")]
	[AddComponentMenu("Sons/Ai/Vail Actor State FX")]
	public class VailActorStateFX : MonoBehaviour
	{
		// Token: 0x060003D8 RID: 984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x2B0B130", Offset = "0x2B09730", VA = "0x182B0B130")]
		private void ActivateObjectDetach(Transform tr, Vector3 position)
		{
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x2B0B2A0", Offset = "0x2B098A0", VA = "0x182B0B2A0")]
		private void ActivateObject(Transform tr)
		{
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x2B0B3B0", Offset = "0x2B099B0", VA = "0x182B0B3B0")]
		private void DeactivateObject(Transform tr)
		{
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x2B0B3C0", Offset = "0x2B099C0", VA = "0x182B0B3C0")]
		private void SpawnFX(GameObject effectPrefab, Vector3 position, Quaternion rotation)
		{
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x2B0B4E0", Offset = "0x2B09AE0", VA = "0x182B0B4E0")]
		public void Tick(VailActor actor)
		{
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x2B0B520", Offset = "0x2B09B20", VA = "0x182B0B520")]
		private void UpdateStatusFx(VailActor actor)
		{
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x2B0B9D0", Offset = "0x2B09FD0", VA = "0x182B0B9D0")]
		public void Clear()
		{
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x2B0BB10", Offset = "0x2B0A110", VA = "0x182B0BB10")]
		private void UpdateSnowEffects(VailActor actor)
		{
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x2B0BD90", Offset = "0x2B0A390", VA = "0x182B0BD90")]
		private void UpdateWaterRippleFX(VailActor actor)
		{
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x2B0BFD0", Offset = "0x2B0A5D0", VA = "0x182B0BFD0")]
		public void OnActorStateChange(VailActor actor, State state)
		{
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x2B0C240", Offset = "0x2B0A840", VA = "0x182B0C240")]
		private VailActorStateFX.ParticleEffect GetParticleEffect(string fxId)
		{
			return null;
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x2B0C3D0", Offset = "0x2B0A9D0", VA = "0x182B0C3D0")]
		public void OnStateFXTriggered(VailActor actor, State state, string fxId)
		{
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x2B0C780", Offset = "0x2B0AD80", VA = "0x182B0C780")]
		public void OnDestroy()
		{
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x2B0CBE0", Offset = "0x2B0B1E0", VA = "0x182B0CBE0")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x2B0CF40", Offset = "0x2B0B540", VA = "0x182B0CF40")]
		private void HideAllStaticFX()
		{
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x2B0D090", Offset = "0x2B0B690", VA = "0x182B0D090")]
		private void ShowStaticFX()
		{
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public VailActorStateFX()
		{
		}

		// Token: 0x04000316 RID: 790
		[Token(Token = "0x4000316")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<VailActorStateFX.StateEffect> _stateEffects;

		// Token: 0x04000317 RID: 791
		[Token(Token = "0x4000317")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<VailActorStateFX.StatusEffect> _statusEffects;

		// Token: 0x04000318 RID: 792
		[Token(Token = "0x4000318")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<VailActorStateFX.ParticleEffect> _particleEffects;

		// Token: 0x04000319 RID: 793
		[Token(Token = "0x4000319")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<VailActorStateFX.WaterEffects> _waterEffects;

		// Token: 0x0400031A RID: 794
		[Token(Token = "0x400031A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<VailActorStateFX.SnowEffects> _snowEffects;

		// Token: 0x02000041 RID: 65
		[Token(Token = "0x2000041")]
		[Serializable]
		private class ParticleEffect
		{
			// Token: 0x060003E9 RID: 1001 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x2B0D2E0", Offset = "0x2B0B8E0", VA = "0x182B0D2E0")]
			public ParticleEffect()
			{
			}

			// Token: 0x0400031B RID: 795
			[Token(Token = "0x400031B")]
			[FieldOffset(Offset = "0x10")]
			public string _id;

			// Token: 0x0400031C RID: 796
			[Token(Token = "0x400031C")]
			[FieldOffset(Offset = "0x18")]
			public GameObject _prefab;

			// Token: 0x0400031D RID: 797
			[Token(Token = "0x400031D")]
			[FieldOffset(Offset = "0x20")]
			[EventRef]
			public string _audioEvent;

			// Token: 0x0400031E RID: 798
			[Token(Token = "0x400031E")]
			[FieldOffset(Offset = "0x28")]
			public VailAudioManager.Noise _noiseStimuli;
		}

		// Token: 0x02000042 RID: 66
		[Token(Token = "0x2000042")]
		[Serializable]
		private class StateEffect
		{
			// Token: 0x060003EA RID: 1002 RVA: 0x00003B40 File Offset: 0x00001D40
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x2B0D2F0", Offset = "0x2B0B8F0", VA = "0x182B0D2F0")]
			private Color GetStateButtonColor()
			{
				return default(Color);
			}

			// Token: 0x060003EB RID: 1003 RVA: 0x0000227A File Offset: 0x0000047A
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x2B0D380", Offset = "0x2B0B980", VA = "0x182B0D380")]
			private IEnumerable GetStateTreeView()
			{
				return null;
			}

			// Token: 0x060003EC RID: 1004 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public StateEffect()
			{
			}

			// Token: 0x0400031F RID: 799
			[Token(Token = "0x400031F")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public State _state;

			// Token: 0x04000320 RID: 800
			[Token(Token = "0x4000320")]
			[FieldOffset(Offset = "0x30")]
			public Transform _staticObject;

			// Token: 0x04000321 RID: 801
			[Token(Token = "0x4000321")]
			[FieldOffset(Offset = "0x38")]
			[HideInInspector]
			public bool _active;
		}

		// Token: 0x02000043 RID: 67
		[Token(Token = "0x2000043")]
		private enum ParticleAttachType
		{
			// Token: 0x04000323 RID: 803
			[Token(Token = "0x4000323")]
			AttachedGround,
			// Token: 0x04000324 RID: 804
			[Token(Token = "0x4000324")]
			Attached,
			// Token: 0x04000325 RID: 805
			[Token(Token = "0x4000325")]
			Detached
		}

		// Token: 0x02000044 RID: 68
		[Token(Token = "0x2000044")]
		[Serializable]
		private class StatusEffect
		{
			// Token: 0x060003ED RID: 1005 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x2B0D3C0", Offset = "0x2B0B9C0", VA = "0x182B0D3C0")]
			public StatusEffect()
			{
			}

			// Token: 0x04000326 RID: 806
			[Token(Token = "0x4000326")]
			[FieldOffset(Offset = "0x10")]
			public StatusEffectType _type;

			// Token: 0x04000327 RID: 807
			[Token(Token = "0x4000327")]
			[FieldOffset(Offset = "0x18")]
			public Transform _staticObject;

			// Token: 0x04000328 RID: 808
			[Token(Token = "0x4000328")]
			[FieldOffset(Offset = "0x20")]
			public VailActorStateFX.ParticleAttachType _attachType;

			// Token: 0x04000329 RID: 809
			[Token(Token = "0x4000329")]
			[FieldOffset(Offset = "0x24")]
			public float _fadeOutTime;

			// Token: 0x0400032A RID: 810
			[Token(Token = "0x400032A")]
			[FieldOffset(Offset = "0x28")]
			[HideInInspector]
			public bool _active;

			// Token: 0x0400032B RID: 811
			[Token(Token = "0x400032B")]
			[FieldOffset(Offset = "0x2C")]
			[HideInInspector]
			public float _stopTime;
		}

		// Token: 0x02000045 RID: 69
		[Token(Token = "0x2000045")]
		[Serializable]
		private class WaterEffects
		{
			// Token: 0x060003EE RID: 1006 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x2B0D3D0", Offset = "0x2B0B9D0", VA = "0x182B0D3D0")]
			public WaterEffects()
			{
			}

			// Token: 0x0400032C RID: 812
			[Token(Token = "0x400032C")]
			[FieldOffset(Offset = "0x10")]
			public ParticleSystem _particles;

			// Token: 0x0400032D RID: 813
			[Token(Token = "0x400032D")]
			[FieldOffset(Offset = "0x18")]
			public float _maxDepthInWater;
		}

		// Token: 0x02000046 RID: 70
		[Token(Token = "0x2000046")]
		[Serializable]
		private class SnowEffects
		{
			// Token: 0x060003EF RID: 1007 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003EF")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public SnowEffects()
			{
			}

			// Token: 0x0400032E RID: 814
			[Token(Token = "0x400032E")]
			[FieldOffset(Offset = "0x10")]
			public ParticleSystem _particles;
		}
	}
}
