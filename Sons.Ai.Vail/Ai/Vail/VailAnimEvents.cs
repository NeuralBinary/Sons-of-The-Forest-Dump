using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x0200004F RID: 79
	[Token(Token = "0x200004F")]
	[AddComponentMenu("Sons/Ai/Vail Anim Events")]
	public class VailAnimEvents : MonoBehaviour
	{
		// Token: 0x0600040B RID: 1035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600040B")]
		[Address(RVA = "0x2B0E720", Offset = "0x2B0CD20", VA = "0x182B0E720")]
		public void SetActor(VailActor actor)
		{
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600040C")]
		[Address(RVA = "0x2B0E820", Offset = "0x2B0CE20", VA = "0x182B0E820")]
		public void OnPickup()
		{
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600040D")]
		[Address(RVA = "0x2B0E840", Offset = "0x2B0CE40", VA = "0x182B0E840")]
		public void OnCarry()
		{
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600040E")]
		[Address(RVA = "0x2B0E9D0", Offset = "0x2B0CFD0", VA = "0x182B0E9D0")]
		public void OnDrop()
		{
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600040F")]
		[Address(RVA = "0x2B0E9F0", Offset = "0x2B0CFF0", VA = "0x182B0E9F0")]
		public void OnPlace()
		{
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000410")]
		[Address(RVA = "0x2B0EA30", Offset = "0x2B0D030", VA = "0x182B0EA30")]
		public void OnInteract(string param)
		{
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000411")]
		[Address(RVA = "0x2B0EB40", Offset = "0x2B0D140", VA = "0x182B0EB40")]
		public void TriggerFX(string fxName)
		{
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000412")]
		[Address(RVA = "0x2B0EBA0", Offset = "0x2B0D1A0", VA = "0x182B0EBA0")]
		public void ShowObject(string objectName, bool active)
		{
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000413")]
		[Address(RVA = "0x2B0ED20", Offset = "0x2B0D320", VA = "0x182B0ED20")]
		public void ChangeState()
		{
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000414")]
		[Address(RVA = "0x2B0ED40", Offset = "0x2B0D340", VA = "0x182B0ED40")]
		public void HitSnapDir()
		{
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000415")]
		[Address(RVA = "0x2B0EDC0", Offset = "0x2B0D3C0", VA = "0x182B0EDC0")]
		public void OnFireRangeWeapon(string weaponName)
		{
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000416")]
		[Address(RVA = "0x2B0EDE0", Offset = "0x2B0D3E0", VA = "0x182B0EDE0")]
		public void ThrowObject(string objectName, bool start)
		{
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000417")]
		[Address(RVA = "0x2B0EE00", Offset = "0x2B0D400", VA = "0x182B0EE00")]
		public void MeleeWeaponOn(string colliderName, bool value, int stateHash)
		{
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000418")]
		[Address(RVA = "0x2B0EE30", Offset = "0x2B0D430", VA = "0x182B0EE30")]
		public void SpawnActor(string param)
		{
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000419")]
		[Address(RVA = "0x2B0EF50", Offset = "0x2B0D550", VA = "0x182B0EF50")]
		internal void SetAnimStateTag(VailAnimStateTag stateTag, bool value)
		{
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041A")]
		[Address(RVA = "0x2B0F1C0", Offset = "0x2B0D7C0", VA = "0x182B0F1C0")]
		internal void RescaleRotationTag(float yawRotate, bool value)
		{
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041B")]
		[Address(RVA = "0x2B0F3A0", Offset = "0x2B0D9A0", VA = "0x182B0F3A0")]
		public void SetRagdoll(bool value)
		{
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041C")]
		[Address(RVA = "0x2B0F3D0", Offset = "0x2B0D9D0", VA = "0x182B0F3D0")]
		public void RagdollIfDead()
		{
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041D")]
		[Address(RVA = "0x2B0F430", Offset = "0x2B0DA30", VA = "0x182B0F430")]
		public void RagdollNamedObject(string namedObject)
		{
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041E")]
		[Address(RVA = "0x2B0F540", Offset = "0x2B0DB40", VA = "0x182B0F540")]
		public void PlayAudioEvent(string eventName)
		{
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041F")]
		[Address(RVA = "0x2B0F5A0", Offset = "0x2B0DBA0", VA = "0x182B0F5A0")]
		public void PlayLoopingAudio(string eventName, bool active)
		{
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000420")]
		[Address(RVA = "0x2B0F610", Offset = "0x2B0DC10", VA = "0x182B0F610")]
		public void CameraShake(float radius)
		{
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000421")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public VailAnimEvents()
		{
		}

		// Token: 0x0400033F RID: 831
		[Token(Token = "0x400033F")]
		[FieldOffset(Offset = "0x20")]
		private VailActor _vailActor;

		// Token: 0x04000340 RID: 832
		[Token(Token = "0x4000340")]
		[FieldOffset(Offset = "0x28")]
		private IActorAudioPlayer _audioPlayer;
	}
}
