using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Endnight.Animation
{
	// Token: 0x020000D1 RID: 209
	[Token(Token = "0x20000D1")]
	public class SkinnedMeshAddressable : MonoBehaviour
	{
		// Token: 0x060004E3 RID: 1251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xAB0FA0", Offset = "0xAAF5A0", VA = "0x180AB0FA0")]
		private void OnEnable()
		{
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E4")]
		[Address(RVA = "0xAB0FB0", Offset = "0xAAF5B0", VA = "0x180AB0FB0")]
		private void OnDisable()
		{
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
		private AssetReference GetAssetReference()
		{
			return null;
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E6")]
		[Address(RVA = "0xAB0FC0", Offset = "0xAAF5C0", VA = "0x180AB0FC0")]
		private void LoadRenderable(AssetReference assetReference)
		{
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E7")]
		[Address(RVA = "0xAB13B0", Offset = "0xAAF9B0", VA = "0x180AB13B0")]
		private void OnHandleCompleted(AsyncOperationHandle<GameObject> operationHandle)
		{
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xAB15E0", Offset = "0xAAFBE0", VA = "0x180AB15E0")]
		private void ClearExistingResult()
		{
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xAB17F0", Offset = "0xAAFDF0", VA = "0x180AB17F0")]
		private void StopExistingOperation()
		{
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xAB18E0", Offset = "0xAAFEE0", VA = "0x180AB18E0")]
		private void OnLoadDone(AsyncOperationHandle<GameObject> operationHandle, Transform rootTransform)
		{
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004EB")]
		[Address(RVA = "0xAB1A60", Offset = "0xAB0060", VA = "0x180AB1A60")]
		private void ApplyModel(Transform modelTransform, Transform rootTransform)
		{
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SkinnedMeshAddressable()
		{
		}

		// Token: 0x04000315 RID: 789
		[Token(Token = "0x4000315")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _rootTransform;

		// Token: 0x04000316 RID: 790
		[Token(Token = "0x4000316")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AssetReference _assetReference;

		// Token: 0x04000317 RID: 791
		[Token(Token = "0x4000317")]
		[FieldOffset(Offset = "0x30")]
		private AsyncOperationHandle<GameObject> _currentResult;
	}
}
