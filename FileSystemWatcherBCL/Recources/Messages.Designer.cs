﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FileSystemWatcherBCL.Recources {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FileSystemWatcherBCL.Recources.Messages", typeof(Messages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Перезаписывает свойство CurrentUICulture текущего потока для всех
        ///   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Creation date.
        /// </summary>
        internal static string DateOfCreation {
            get {
                return ResourceManager.GetString("DateOfCreation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Enter Ctrl+X for exit program.
        /// </summary>
        internal static string ExitProgram {
            get {
                return ResourceManager.GetString("ExitProgram", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на New file was created.
        /// </summary>
        internal static string FileFounded {
            get {
                return ResourceManager.GetString("FileFounded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на This file successfully passed the rules check..
        /// </summary>
        internal static string MatchWithRule {
            get {
                return ResourceManager.GetString("MatchWithRule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на This file moved to Document Folder..
        /// </summary>
        internal static string MoveInDocumentFolder {
            get {
                return ResourceManager.GetString("MoveInDocumentFolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на This file moved to Picture Folder..
        /// </summary>
        internal static string MoveInPictureFolder {
            get {
                return ResourceManager.GetString("MoveInPictureFolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на This file moved to Text Folder..
        /// </summary>
        internal static string MoveInTextFolder {
            get {
                return ResourceManager.GetString("MoveInTextFolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на This file does not match any rule..
        /// </summary>
        internal static string NotMatchWithRule {
            get {
                return ResourceManager.GetString("NotMatchWithRule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на File.
        /// </summary>
        internal static string OnChangeMessage {
            get {
                return ResourceManager.GetString("OnChangeMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на The file was renamed.
        /// </summary>
        internal static string OnRenameMessage {
            get {
                return ResourceManager.GetString("OnRenameMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Do you want to read rules from config file?.
        /// </summary>
        internal static string PickConfig {
            get {
                return ResourceManager.GetString("PickConfig", resourceCulture);
            }
        }
    }
}
