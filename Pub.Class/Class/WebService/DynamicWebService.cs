//------------------------------------------------------------
// All Rights Reserved , Copyright (C) 2011 , LiveXY , Ltd. 
//------------------------------------------------------------

using System;
using System.Collections;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Caching;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Pub.Class {
    /// <summary>
    /// WebService ��̬����
    /// 
    /// �޸ļ�¼
    ///     2011.11.09 �汾��1.0 livexy ��������
    /// 
    /// <code>
    /// <example>
    /// Hashtable pas = new Hashtable(); pas["i"] = 100;
    /// new DynamicWebService().Call("http://www.test.com/default.asmx", "WebService", "test2", pas);
    /// </example>
    /// </code>
    /// </summary>
    public class DynamicWebService : IWebService {
        /// <summary>
        /// WebService ��̬��ʽ����
        /// </summary>
        /// <param name="url">WebService �ӿڵ�ַ</param>
        /// <param name="className">����</param>
        /// <param name="methodName">������</param>
        /// <param name="parms">����</param>
        /// <returns>�����ַ���</returns>
        public string Call(string url, string className, string methodName, Hashtable parms) {
            return WebService.DynamicWebService(url, className, methodName, parms);
        }
        /// <summary>
        /// WebService ��̬��ʽ����
        /// </summary>
        /// <param name="url">WebService �ӿڵ�ַ</param>
        /// <param name="className">����</param>
        /// <param name="methodName">������</param>
        /// <param name="parms">����</param>
        /// <returns>�����ַ���</returns>
        public string Call(string url, string className, string methodName, IList<UrlParameter> parms) {
            return WebService.DynamicWebService(url, className, methodName, parms);
        }
    }
}